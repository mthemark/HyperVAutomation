# Hyper-V Automation Project

This project automates the setup, configuration, and deployment of Hyper-V virtual machines using C#. It provides a set of services and utilities to manage virtual machines efficiently.

## Copilot Prompts

# Copilot - workspace

1. I want to setup a project to allow easy setup, configuration and deployment of HyperV VMs. can you please suggest some automation tools or project structure for this task in vscode? please suggest a C# based solution, but other solutions are okay too.
2. What libraries would you use to created the VMs? System.Management.Automation?
3. Can you please include a powershell script to install this module if it is not installed too?

# Copilot - ConfigurationService.cs
// load configuration for multiple VirtualMachine from file
// save configuration for multiple VirtualMachine to file
// set configFilePath

# Copilot - Program.cs
// ensure Hyper-V module is installed
// get files in the ./vmconfig folder ending with .json
// allow user to select one of the config files
// handle user input to select a single vm from vmconfigs
// handle user input to continue vm management or exit

# Dev - upgrade to .net9.0
# Dev - add package Microsoft.PowerShell.SDK 7.5
# Dev - create vmconfig folder and add README.md

# Copilot - workspace
1. can you please create and example vmconfig file, myvm.json?
2. with multiple vms, and named myvms.json

# Dev - create myvms.json and preview copilot suggestion

# Copilot - Program.cs
// thank you for using the tool

##

## Project Structure

HyperVAutomation
└── HyperVAutomation
|   ├── src
|       ├── Program.cs
|       ├── Services
|           ├── HyperVService.cs
|           └── ConfigurationService.cs
|       ├── Models
|           └── VirtualMachine.cs
|       └── Utilities
|           └── PowerShellHelper.cs
|   ├── scripts
|       └── InstallHyperVModule.ps1
|   ├── HyperVAutomation.csproj
|   └── README.md

## Setup Instructions

1. **Clone the repository**:
   ```
   git clone https://github.com/mthemark/HyperVAutomation.git
   
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