 # hello-world
+
 Learning to usual things
 Crazy, lazy, goodman
+
+## Repository structure
+
+```
+.
+├── docs/            # Architecture, roadmap, and planning notes
+├── scripts/         # Development helpers
+├── src/
+│   ├── AndroidClient/  # Android UI shell
+│   ├── Core/           # Core connection logic (no UI dependencies)
+│   ├── Shared/         # Shared models/utilities
+│   └── WindowsClient/  # Windows demo shell
+└── tests/           # Test projects
+```
+
+## Quick start (demo)
+
+```bash
+dotnet run --project src/WindowsClient/WindowsClient.csproj
+```
+
+## Planning docs
+- `docs/architecture.md`
+- `docs/roadmap.md`
+- `docs/tech-stack.md`
+- `docs/core-lifecycle.md`
+- `docs/core-interfaces.md`
+- `docs/next-steps.md`
