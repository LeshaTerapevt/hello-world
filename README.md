 (cd "$(git rev-parse --show-toplevel)" && git apply --3way <<'EOF' 
diff --git a/README.md b/README.md
index 5ec0cce714fcd5c473edba40f015468840805ba6..1cd0bdd2a3c6bcb4dfb62c719f34b25734cd14f6 100644
--- a/README.md
+++ b/README.md
@@ -1,3 +1,26 @@
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
+│   └── WindowsClient/  # Windows UI shell
+└── tests/           # Test projects
+```
+
+## Planning docs
+- `docs/architecture.md`
+- `docs/roadmap.md`
+- `docs/tech-stack.md`
+- `docs/core-lifecycle.md`
+- `docs/core-interfaces.md`
+- `docs/next-steps.md`
 
EOF
)
