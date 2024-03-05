# JTool

JTool is a simple C# Windows Forms application designed to assist with various development tasks. Currently, it supports the scaffold operation for Entity Framework Core but more functionality will be added as I need it.

## Features

- **Scaffold Operation**: Generate Entity Framework Core DbContext and entity classes from an existing database using the Entity Framework Core tools.

## Getting Started

To use JTool, follow these steps:

1. Clone the repository to your local machine.
2. Build the solution using Visual Studio or another C# development environment.
3. Run the executable file (`.exe`) generated in the `bin` directory.

## Usage

1. **Scaffold Operation**: 
   - Enter the connection string for your database.
   - Specify the project directory, output directory, and context directory.
   - Set any additional flags for the scaffold operation.
   - Click the "Scaffold" button to execute the operation.