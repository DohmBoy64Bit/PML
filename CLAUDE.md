# Polytoria Mod Loader (PML)

## Build Commands
- **Build Solution**: `dotnet build new-task-206d.slnx`
- **Build Loader**: `dotnet build src/PolytoriaLoader/PolytoriaLoader.csproj`
- **Build SDK**: `dotnet build src/PML.SDK/PML.SDK.csproj`

## Lint Commands
- **Format Code**: `dotnet format new-task-206d.slnx`
- **Check Format**: `dotnet format new-task-206d.slnx --verify-no-changes`

## Project Structure
- `src/PolytoriaLoader`: Core loader logic.
- `src/PML.SDK`: Plugin SDK for mod developers.
- `PML_Internal/Il2CppAssemblies/`: Generated Unity DLLs and dependencies.
- `Mods/`: Directory for user mods.
