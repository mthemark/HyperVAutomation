# Hyper-V Automation Project

This project automates the setup, configuration, and deployment of Hyper-V virtual machines using C#. It provides a set of services and utilities to manage virtual machines efficiently.

## Project Structure

```
HyperVAutomation
├── src
│   ├── Program.cs
│   ├── Services
│   │   ├── HyperVService.cs
│   │   └── ConfigurationService.cs
│   ├── Models
│   │   └── VirtualMachine.cs
│   ├── Utilities
│       └── PowerShellHelper.cs
├── HyperVAutomation.csproj
└── README.md
```

## Setup Instructions

1. **Clone the repository**:
   ```
   git clone <repository-url>
   ```

2. **Navigate to the project directory**:
   ```
   cd HyperVAutomation
   ```

3. **Restore dependencies**:
   ```
   dotnet restore
   ```

4. **Build the project**:
   ```
   dotnet build
   ```

## Usage

1. **Run the application**:
   ```
   dotnet run --project src/Program.cs
   ```

2. **Follow the prompts** to create, start, stop, or delete Hyper-V virtual machines.

## Automation Tools

- **PowerShell**: Utilized for executing Hyper-V management commands.
- **.NET Core**: Framework used for building and running the application.

## Contributing

Feel free to submit issues or pull requests for enhancements and bug fixes.