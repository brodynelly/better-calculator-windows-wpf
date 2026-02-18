# Calculator App

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT) [![CI](https://github.com/brodynelly/better-calculator-windows-wpf/actions/workflows/ci.yml/badge.svg)](https://github.com/brodynelly/better-calculator-windows-wpf/actions/workflows/ci.yml) ![C#](https://img.shields.io/badge/C%23-.NET_8-purple?logo=dotnet)

A simple WPF Calculator application written in C#.


## Tech Stack

- **C# / .NET 8** — application logic
- **WPF** — Windows Presentation Foundation UI
- **NUnit** — unit testing


## Architecture

The application is refactored to separate the UI logic from the calculation logic.

- **src/Calculator**: The main WPF application.
  - `MainWindow.xaml`: The user interface.
  - `Logic/CalculatorEngine.cs`: The core calculation logic.
- **tests/Calculator.Tests**: Unit tests for the application.

## Getting Started

### Prerequisites

- .NET 8.0 SDK or later.

### Building

```bash
dotnet build
```

### Running Tests

```bash
dotnet test
```

## Contributing

Please follow the naming conventions:
- **C#**: PascalCase for classes/methods, camelCase for fields/locals.
- **Branches**: `{type}/{scope}-{desc}` (e.g., `feat/ui-redesign`).
- **Commits**: Conventional Commits.

## License

MIT
