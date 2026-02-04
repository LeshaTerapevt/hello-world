# Core: интерфейсы (черновик)

Минимальные интерфейсы для MVP, чтобы отделить UI от логики подключения.

## IConnectionManager
**Ответственность:** управляет состоянием подключения.

Методы:
- `ConnectAsync()`
- `DisconnectAsync()`
- `GetStatus()`

События:
- `StatusChanged`
- `ErrorOccurred`

## IConfigurationStore
**Ответственность:** хранение и чтение конфигураций.

Методы:
- `Load()`
- `Save(config)`

## IDiagnostics
**Ответственность:** базовая диагностика и логирование.

Методы:
- `LogInfo(message)`
- `LogWarning(message)`
- `LogError(message, exception)` енрр54кнр5

щжлжл
