# Technical Specification: Polytoria Mod Loader (PML)

## 1. Technical Context
- **Target Platform**: Windows (x64)
- **Runtime**: .NET 6.0 (CoreCLR)
- **Game Engine**: Unity 6 (6000.3.7f1)
- **IL2CPP Metadata**: Version 39
- **Injection**: Doorstop 4+ (`winhttp.dll`)
- **Primary Dependencies**:
    - `Il2CppInterop 1.5.1`: For IL2CPP <-> .NET 6 mapping.
    - `Iced 1.17.0+`: For assembly cross-referencing and Xref scanning.
    - `dnlib`: For runtime assembly analysis.
    - `MoonSharp`: For Lua integration.

## 2. Implementation Approach

### 2.1. Bootstrapper (Entrypoint)
The loader will be a standalone assembly `PolytoriaLoader.dll`.
- **Entrypoint**: `PolytoriaLoader.Core.Entrypoint::Start` (called via Doorstop).
- **Console**: Uses Win32 `AllocConsole` to provide immediate feedback.
- **Safety Delay**: Implements a `Task.Delay(12000)` before initializing `Il2CppInteropRuntime` to ensure Unity's metadata buffers are fully mapped in memory.
- **Metadata Patching**: Since `Il2CppInterop 1.5.1` might not natively support Metadata v39, we will use `dnlib` or runtime hooks to spoof the metadata version to a supported one (e.g., v29 or v31) if the interop fails to initialize, or manually provide the offsets found via `Iced`.

### 2.2. Recursive Assembly Resolver
A custom `AssemblyResolve` handler will be registered:
- **Tiers**:
    1. `PML_Internal/Il2CppAssemblies/`: System-level and generated assemblies.
    2. `Mods/[ModName]/`: Mod-specific DLLs.
    3. `Mods/[ModName]/Deps/`: External dependencies for the mod.
- **Logic**: Recursively scans these directories on failed resolution.

### 2.3. Developer Console & Logger
- A singleton `PML.Logger` will handle stdout redirection.
- Prefix mapping:
    - `[PML:CORE]`: Internal loader state.
    - `[PML:V39]`: Metadata mapping logs.
    - `[PML:LUA]`: MoonSharp activity.
    - `[PML:MOD]`: General mod output.

### 2.4. MoonSharp Lua Bridge
A static class `PML.Lua` will manage interaction with Polytoria's Lua state.
- **Capture**: Uses `Iced` to find the method pointers for `MoonSharp.Interpreter.Script` constructors or use Harmony to hook them.
- **Instance Tracking**: Stores active `Script` instances in a `List<Script>`.
- **API**:
    - `Run(string lua)`: Executes code on all tracked scripts.
    - `Register(string name, Delegate action)`: Injects C# functions into the global Lua environment.

### 2.5. Plugin SDK (PML.SDK)
A base class `PolytoriaMod` provided in a referenced DLL.
- **Lifecycle**:
    - `OnInitialize()`: Boot-time setup.
    - `OnUnityReady()`: Triggered via a `MainThreadDispatcher` once `GameObject.Internal_CreateGameObject` or similar is available.
    - `OnUpdate()`: Hooked into the Unity main loop.

## 3. Source Code Structure
```text
src/
├── PolytoriaLoader/
│   ├── Core/
│   │   ├── Entrypoint.cs
│   │   ├── AssemblyResolver.cs
│   │   └── Logger.cs
│   ├── Interop/
│   │   ├── MetadataPatches.cs
│   │   └── XrefScanner.cs (using Iced)
│   ├── Lua/
│   │   └── LuaBridge.cs
│   └── Utils/
│       ├── Win32.cs
│       └── MainThreadDispatcher.cs
└── PML.SDK/
    └── PolytoriaMod.cs
```

## 4. Delivery Phases

### Phase 1: Bootstrapping & Console
- Implement `AllocConsole`.
- Implement `doorstop_config.ini` setup.
- Basic logging system.

### Phase 2: Interop & Metadata v39
- Configure `Il2CppInterop`.
- Implement the 12-second safety wait.
- Implement `Iced` fallback for metadata lookup.

### Phase 3: Assembly Resolution
- Implement the 3-tier recursive resolver.
- Ensure `MoonSharp.Interpreter.dll` is correctly loaded from `Deps/`.

### Phase 4: Lua Bridge & SDK
- Implement `PolytoriaMod` lifecycle.
- Implement `PML.Lua` for script execution and registration.
- Implement `MainThreadDispatcher`.

### Phase 5: Conversion of "The Bad Place Executor"
- Port the MelonLoader mod to `PolytoriaMod`.
- Adapt the IPC server and MoonSharp capture logic.

## 5. Verification Approach
- **Logging**: Verify `[PML:CORE]` and `[PML:V39]` appear in the console.
- **Mod Loading**: Create a "Hello World" mod and verify `OnInitialize` and `OnUnityReady` fire.
- **Lua Execution**: Use `pml` console commands or the mod to run `print("PML Loaded")` in the game's Lua state.
- **Stability**: Ensure the game doesn't crash if a mod throws an exception in `OnUpdate`.
