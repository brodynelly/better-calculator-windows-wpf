# Migration Guide

This document details the changes made during the refactoring process.

## Summary of Changes

- **Project Structure**: Moved source code to `src/` and tests to `tests/`.
- **Logic Separation**: Extracted calculation logic from `MainWindow.xaml.cs` to `Calculator.Logic.CalculatorEngine` class.
- **Naming Conventions**:
  - Updated XAML control names to follow `camelCase` (e.g., `inputSeven` instead of `input_Seven`).
  - Corrected confusing naming for `inputZero` and `inputPeriod`.
- **Testing**: Added xUnit tests for the calculation logic.
- **CI/CD**: Added GitHub Actions workflow for building and testing.
- **Linting**: Added `.editorconfig` for consistent coding style.

## Breaking Changes

- The project file location has changed. If you are opening the project in Visual Studio, please open the new `Calculator.sln` at the root.
