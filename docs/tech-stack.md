# Tech Stack (Initial)

This document captures the agreed initial stack for the MVP.

## Clients
- **Windows**: C# (.NET), native desktop UI.
- **Android**: Kotlin, native mobile UI.

## Core
- Shared, UI-agnostic core library that handles connection lifecycle,
  configuration, and diagnostics.

## Notes
- Prioritize reliability and clear diagnostics over feature breadth.
- Keep the core library independent of UI frameworks to allow future GUI changes.
