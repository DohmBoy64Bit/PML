# Full SDD workflow

## Configuration
- **Artifacts Path**: {@artifacts_path} → `.zenflow/tasks/{task_id}`

---

## Workflow Steps

### [x] Step: Requirements
<!-- chat-id: 0d6d58ed-7c35-4277-8685-48166375733f -->

Create a Product Requirements Document (PRD) based on the feature description.

1. Review existing codebase to understand current architecture and patterns
2. Analyze the feature definition and identify unclear aspects
3. Ask the user for clarifications on aspects that significantly impact scope or user experience
4. Make reasonable decisions for minor details based on context and conventions
5. If user can't clarify, make a decision, state the assumption, and continue

Save the PRD to `{@artifacts_path}/requirements.md`.

### [x] Step: Technical Specification
<!-- chat-id: 71e14bad-89fa-4dd7-8a36-71338d3d860b -->

Create a technical specification based on the PRD in `{@artifacts_path}/requirements.md`.

1. Review existing codebase architecture and identify reusable components
2. Define the implementation approach

Save to `{@artifacts_path}/spec.md` with:
- Technical context (language, dependencies)
- Implementation approach referencing existing code patterns
- Source code structure changes
- Data model / API / interface changes
- Delivery phases (incremental, testable milestones)
- Verification approach using project lint/test commands

### [x] Step: Planning
<!-- chat-id: 95fb6956-0b15-4cb7-bb9b-10a0b7e9fc92 -->

Create a detailed implementation plan based on `{@artifacts_path}/spec.md`.

1. Break down the work into concrete tasks
2. Each task should reference relevant contracts and include verification steps
3. Replace the Implementation step below with the planned tasks

Rule of thumb for step size: each step should represent a coherent unit of work (e.g., implement a component, add an API endpoint). Avoid steps that are too granular (single function) or too broad (entire feature).

Important: unit tests must be part of each implementation task, not separate tasks. Each task should implement the code and its tests together, if relevant.

If the feature is trivial and doesn't warrant full specification, update this workflow to remove unnecessary steps and explain the reasoning to the user.

Save to `{@artifacts_path}/plan.md`.

### [x] Step: Project Scaffolding
<!-- chat-id: 5e970702-9c33-43dc-9e55-79b678e736b0 -->
- Create `src/PolytoriaLoader` and `src/PML.SDK` projects targeting .NET 6.0.
- Set up directory structure: `PML_Internal/Il2CppAssemblies/`, `Mods/`.
- Configure `CLAUDE.md` with build and lint commands.
- Verification: Projects build successfully as class libraries.

### [x] Step: Core Bootstrapper & Console
<!-- chat-id: 8cbba645-22e2-43d3-b8bd-02be80ddefed -->
- Implement Win32 console allocation (`AllocConsole`).
- Create `Logger.cs` with `[PML:CORE]`, `[PML:V39]`, `[PML:LUA]`, `[PML:MOD]` prefixes.
- Implement `Entrypoint.Start` as the Doorstop entrypoint.
- Verification: Log "PML Booting" and verify it appears in a new console window.

### [ ] Step: Assembly Resolver
- Implement `AssemblyResolver.cs` with 3-tier recursive logic (System, Plugin, Dependency).
- Register `AppDomain.CurrentDomain.AssemblyResolve`.
- Verification: Unit test with dummy DLLs in `PML_Internal/` and `Mods/ModName/Deps/`.

### [ ] Step: Interop & Metadata v39 Support
- Implement 12-second safety delay in `Entrypoint.cs`.
- Integrate `Iced` for Xref scanning.
- Implement metadata version override or manual pointer lookup for `Il2CppInterop`.
- Verification: Successfully identify game method pointers using `Iced`.

### [ ] Step: Lua Bridge & MainThreadDispatcher
- Implement `MainThreadDispatcher` for marshaling calls to Unity's main thread.
- Implement `LuaBridge.cs` to track `MoonSharp.Interpreter.Script` instances.
- Implement `PML.Lua` API (`Run`, `Register`).
- Verification: Execute a Lua `print` statement from C# and verify output.

### [ ] Step: Plugin SDK & Lifecycle Hooks
- Implement `PolytoriaMod` abstract class in `PML.SDK`.
- Implement mod discovery and instantiation logic.
- Implement lifecycle calls: `OnInitialize`, `OnUnityReady`, `OnUpdate`.
- Wrap `OnUpdate` in try-catch for error isolation.
- Verification: Create a test mod and verify all lifecycle hooks trigger correctly.

### [ ] Step: Conversion of "The Bad Place Executor"
- Port the MelonLoader mod from `ConvertThisMod/` to the PML SDK.
- Adapt the IPC server and MoonSharp script execution logic.
- Verification: Verify the converted mod can receive and execute Lua scripts via IPC.
