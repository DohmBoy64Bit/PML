# Product Requirements Document (PRD) - Polytoria Mod Loader (PML)

## 1. Overview
Polytoria Mod Loader (PML) is a standalone modding framework for Polytoria, targeting Unity 6 (IL2CPP) with .NET 6.0 (CoreCLR). It uses Doorstop 4+ for injection and provides a Lua scripting bridge via MoonSharp.

## 2. Objectives
- Provide a stable entry point into the Polytoria game process.
- Support IL2CPP Metadata version 39.
- Implement a tiered assembly resolution system for a clean root directory.
- Provide a developer console for logging and basic commands.
- Expose an API for C# mods to interact with the game's MoonSharp Lua environment.
- Provide a standardized Plugin SDK for mod developers.

## 3. Functional Requirements

### 3.1. Loader & Entrypoint
- **Injection**: Must be compatible with Doorstop 4+.
- **Console**: Must allocate a Win32 console immediately upon startup.
- **Metadata Support**: Must handle IL2CPP Metadata v39, specifically ensuring `Il2CppInterop 1.5.1` compatibility by overriding version detection if necessary.
- **Boot Sequence**: Must implement a 12-second delay before starting the `Il2CppInteropRuntime` scan to allow Unity metadata to initialize.

### 3.2. Assembly Management
- **Resolver**: Implement a recursive assembly resolver that searches the following tiers:
    1. `PML_Internal/Il2CppAssemblies/`: Core internal and generated Unity DLLs.
    2. `Mods/[ModName]/`: Main mod assemblies.
    3. `Mods/[ModName]/Deps/`: Mod-specific dependencies.

### 3.3. Developer Console
- **Output**: Support categorized logging: `[PML:CORE]`, `[PML:V39]`, `[PML:LUA]`, `[PML:MOD]`.
- **Input**: Support basic commands:
    - `pml list`: List loaded mods.
    - `pml clear`: Clear console buffer.

### 3.4. MoonSharp Integration
- **Tracking**: Track `MoonSharp.Interpreter.Script` instances within the game using Reflection.
- **API**:
    - `PML.Lua.Run(string lua)`: Execute Lua code in the global state.
    - `PML.Lua.Register(string name, Delegate action)`: Expose C# methods to Lua.

### 3.5. Plugin SDK
- **Base Class**: `PolytoriaMod` abstract class with mandatory `Name` and `Version` properties.
- **Lifecycle Hooks**:
    - `OnInitialize()`: Called during loader boot.
    - `OnUnityReady()`: Called when the Unity 6 domain is active.
    - `OnUpdate()`: Called every frame.
- **Safety**: Each mod's `OnUpdate` must be isolated with try-catch blocks to prevent a single mod from crashing the game.

## 4. Technical Requirements
- **Runtime**: .NET 6.0 (CoreCLR).
- **Game Engine**: Unity 6 (6000.3.7f1).
- **Libraries**:
    - `Iced` (>= 1.17.0) for Xref scanning and manual pointer lookup.
    - `dnlib` for assembly manipulation/analysis.
    - `MoonSharp` for Lua interop.
- **Threading**: Implement a `MainThreadDispatcher` for safe interaction with Unity APIs from background threads.

## 5. Constraints & Assumptions
- **Metadata 39**: Assumed that manual version mapping is required for `Il2CppInterop`.
- **Doorstop**: Assumed `doorstop_config.ini` will be configured as specified in the task description.
- **File Layout**: Must strictly follow the specified directory structure.

- **References**:
    - `ConvertThisMod/`: A MelonLoader mod that needs to be converted to the new PML system. It includes an IPC server and MoonSharp script execution.
    - `PolyTopiaSource/`: Decompiled IL2CPP source code of the game for reference.

## 6. Open Questions (Answered)
- Where is the IL2CPP game directory located? (Assume standard root, layout provided in specs).
- Can I see the example MelonLoader mod to be converted? (Provided in `ConvertThisMod/`).
- Are the DLLs in `Il2CppAssemblies/` provided or should the loader generate them? (Likely generated or provided in `PML_Internal/` in the final build, but for development, I have the source).
- How does the game store its `MoonSharp.Interpreter.Script` instances? (Found standard MoonSharp in `PolyTopiaSource`).
