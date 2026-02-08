# Polytoria Mod Loader (PML)

Polytoria Mod Loader (PML) is a high-performance, standalone modding framework designed for Polytoria. It targets .NET 6.0 and Unity 6 (IL2CPP Metadata v39), providing a robust environment for both C# and Lua-based modifications.

## 🚀 Features

- **Doorstop 4+ Injection**: Seamlessly integrates into the game process.
- **Metadata v39 Support**: Custom handling for the latest IL2CPP metadata versions, including a 12-second safety delay for stable initialization.
- **Integrated Developer Console**: Real-time logging with categorized tags (`CORE`, `V39`, `LUA`, `MOD`).
- **MoonSharp Lua Bridge**: Global access to the game's Lua environment with the ability to run scripts and register C# functions.
- **Recursive Assembly Resolution**: Clean path management for system, plugin, and dependency DLLs.
- **Thread Safety**: `MainThreadDispatcher` ensures Unity API calls are marshaled correctly from background threads.

## 📁 Project Structure

- [./src/PolytoriaLoader/](./src/PolytoriaLoader/): Core loader logic, injection handling, and assembly resolution.
- [./src/PML.SDK/](./src/PML.SDK/): The developer SDK containing base classes and APIs for mod creation.
- [./src/TheBadPlaceExecutor/](./src/TheBadPlaceExecutor/): An example mod converted from MelonLoader, featuring IPC script execution.
- [./PML_Internal/Il2CppAssemblies/](./PML_Internal/Il2CppAssemblies/): Storage for generated Unity interop DLLs.
- [./Mods/](./Mods/): The directory where compiled mods should be placed.

## 🛠 Building

PML uses the modern `.slnx` solution format.

```bash
# Build the entire solution
dotnet build new-task-206d.slnx

# Build specific components
dotnet build src/PolytoriaLoader/PolytoriaLoader.csproj
dotnet build src/PML.SDK/PML.SDK.csproj
```

## 📦 Installation

1. Copy `winhttp.dll` (Doorstop) to the game root.
2. Place `PolytoriaLoader.dll` and `doorstop_config.ini` in the game root.
3. Ensure `PML_Internal/Il2CppAssemblies/` contains the necessary interop DLLs.
4. Place your mods in the `Mods/[ModName]/` directory.

### `doorstop_config.ini` (Doorstop 4 CoreCLR)
```ini
[General]
enabled=true
target_assembly=PolytoriaLoader.dll
redirect_output_log=true

[Il2Cpp]
coreclr_path=C:\Program Files\dotnet\shared\Microsoft.NETCore.App\6.0.36\coreclr.dll
corlib_dir=C:\Program Files\dotnet\shared\Microsoft.NETCore.App\6.0.36\
```

**Note:** The entrypoint must be `Doorstop.Entrypoint.Start()`. PML handles this automatically.

## 👨‍💻 Mod Development (PML.SDK)

Creating a mod is simple. Inherit from `PolytoriaMod` and implement the lifecycle hooks.

```csharp
public class MyMod : PolytoriaMod
{
    public override string Name => "My Cool Mod";
    public override string Version => "1.0.0";

    public override void OnInitialize()
    {
        ConsoleLog("Initialized!");
    }

    public override void OnUnityReady()
    {
        // Access Lua environment
        PML.Lua.Run("print('Hello from PML!')");
        
        // Register a C# function to Lua
        PML.Lua.Register("my_func", (Action<string>)((msg) => {
            ConsoleLog($"Lua said: {msg}");
        }));
    }
}
```

## 📝 Technical Details

- **Iced Integration**: Uses `Iced` for Xref scanning to locate game method pointers in Metadata v39 environments.
- **Error Isolation**: Each mod's `OnUpdate` loop is wrapped in a try-catch block to prevent a single failing mod from crashing the loader or the game.
- **Main Thread Dispatcher**: Mod developers can use `MainThreadDispatcher.Enqueue` to safely execute code on the Unity main thread.

## ⚖ License
Refer to the project's license file for terms of use.
