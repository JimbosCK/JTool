# JTool

JTool is a simple C# Windows Forms application designed to assist with various development tasks. Currently, it supports the scaffold operation for Entity Framework Core but more functionality will be added as I need it.

## Features

- **Scaffold Operation**: Generate Entity Framework Core DbContext and entity classes from an existing database using the Entity Framework Core tools.

## Getting Started

To use JTool, follow these steps:

1. Download the latest released version (JTool zip).
2. Extract the files.
3. Run the executable file (`.exe`).

## Usage

1. **Scaffold Operation**: 
   - Enter the connection string for your database.
   - Specify the project directory, output directory, and context directory.
   - Set any additional flags for the scaffold operation.
   - Click the "Scaffold" button to execute the operation.
   
## Useful Links

- [Scaffolding (Reverse Engineering)](https://learn.microsoft.com/en-us/ef/core/managing-schemas/scaffolding/?tabs=dotnet-core-cli)
- [Entity Framework Core tools reference - Package Manager Console in Visual Studio](https://learn.microsoft.com/en-us/ef/core/cli/powershell)
