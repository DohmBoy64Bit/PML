# Polytoria Mod Loader (PML)

A standalone mod loader for Polytoria, targeting Unity 6 (Metadata v39) and .NET 6 (CoreCLR).

## 🚀 Features
- **Modern .NET 6 CoreCLR Support**: Powered by UnityDoorstop 4+.
- **Unity 6 Compatibility**: Custom Metadata v39 support via Il2CppInterop 1.5.1.
- **Lua Integration**: Native bridge for MoonSharp to interact with game scripts.
- **IPC Support**: Remote script execution via Named Pipes.
- **Developer Console**: Real-time logging and command interface.

## 🛠️ Installation

1. Download the latest PML release.
2. Place `winhttp.dll`, `doorstop_config.ini`, and `PolytoriaLoader.dll` in your Polytoria Client directory.
3. Create a `PML_Internal/Il2CppAssemblies` folder and place the required interop DLLs there.
4. (Optional) Create a `Mods` folder for your plugins.

## 📂 Project Structure
- `src/PolytoriaLoader`: Core loader logic.
- `src/PML.SDK`: Plugin SDK for mod developers.
- `src/TheBadPlaceExecutor`: Ported script executor with IPC support.
- `Mods/`: Directory for user mods.
- `PML_Internal/Il2CppAssemblies/`: Generated Unity DLLs.

## 💻 Building

```bash
dotnet build new-task-206d.slnx
```

## 📝 License
MIT
