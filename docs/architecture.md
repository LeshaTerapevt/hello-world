# Architecture (High-Level)

## Components
- **Control Plane**: user/device management, configuration, and observability hooks.
- **Data Plane**: networking nodes that carry user traffic.
- **Clients**: Windows and Android apps that connect to nodes.

## Goals
- Reliability first (auto-reconnect, fallback transport options).
- Clear separation of UI and core networking logic.
- Minimal data collection.
