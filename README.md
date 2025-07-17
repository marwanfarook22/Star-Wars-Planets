 # Star Wars Planets Stats 🌌

A C# application to explore and display Star Wars planets' statistics, showcasing LINQ, Generics, and ASCII table printing! 🚀

![Build Status](https://img.shields.io/badge/build-passing-brightgreen)
![License](https://img.shields.io/badge/license-MIT-blue)

## Table of Contents
- [Introduction](#introduction)
- [Features](#features)
- [Technologies](#technologies)
- [Installation](#installation)
- [Usage](#usage)
- [Data Source](#data-source)
- [Optional: Universal Table Printer](#optional-universal-table-printer)
- [Contributing](#contributing)
- [License](#license)

## Introduction
The **Star Wars Planets Stats** is a C# project developed as part of the *Ultimate C# Masterclass* assignment. This application retrieves and processes planetary data from the Star Wars universe, presenting it in a clean, tabular format. Originally designed to use the SWAPI (Star Wars API), it now leverages a mock data provider (`MockStarWarsApiDataReader`) due to the API's unavailability. The project showcases advanced C# features like LINQ, Generics, and ASCII table printing, making it both educational and fun for developers and Star Wars fans alike! ✨

 

## Features
- 🌍 Retrieve and display Star Wars planets' statistics
- ✅ Process data using LINQ queries for filtering and sorting
- 📊 Print planet data in a customizable ASCII table
- 🔧 Use Generics for a flexible, reusable table printer
- 🛠️ Robust fallback to mock data when the external API is unavailable

## Technologies
This project highlights the following C# technologies:
- **LINQ**: For querying and manipulating planet data efficiently.
- **Generics**: To create a universal table printer that works with any object type.
- **ASCII**: For rendering clean, tabular output in the console.
- **API Integration**: Designed to work with the SWAPI (with a mock fallback).

## Installation
To get started with Star Wars Planets Stats, follow these steps:

1. **Clone the repository**:
   ```bash
   git clone https://github.com/username/star-wars-planets-stats.git
   ```
2. **Navigate to the project directory**:
   ```bash
   cd star-wars-planets-stats
   ```
3. **Restore dependencies**: Ensure you have the .NET SDK installed, then run:
   ```bash
   dotnet restore
   ```
4. **Build the project**:
   ```bash
   dotnet build
   ```

**Prerequisites**:
- .NET SDK (version 6.0 or higher)
- A C# IDE (e.g., Visual Studio, VS Code, or Rider)

## Usage
Run the application to explore Star Wars planets' statistics:
```bash
dotnet run
```

Example usage:
- Display all planets in a tabular format with properties like Name, Diameter, and Population.
- Use LINQ to filter planets (e.g., by climate or terrain).
- Customize the table output using the universal table printer.

For detailed code examples, check the `src/` directory.

## Data Source
**⚠️ Warning**: The original SWAPI (Star Wars API) is no longer available. To ensure reliability, this project uses the `MockStarWarsApiDataReader` namespace as an alternative data source. The mock data provider simulates API responses and is included in the Git repository or the resources of the “Assignment - Star Wars Planets Stats - Description and requirements” lecture.

The mock data ensures the application remains functional without relying on an external API. The source code for `MockStarWarsApiDataReader` is available in the `src/` directory.

## Optional: Universal Table Printer
An optional feature of this project is a **generic table printer** that can display any collection of objects in a tabular format. This printer:
- Uses **Generics** to accept any object type.
- Renders properties dynamically in an ASCII table.
- Example output for planets:
  ```
  +----------------+------------+------------+
  | Name           | Diameter   | Population |
  +----------------+------------+------------+
  | Tatooine       | 10465      | 200000     |
  | Alderaan       | 12500      | 2000000000 |
  +----------------+------------+------------+
  ```

Check the `src/TablePrinter.cs` file for the implementation details.

## Contributing
We welcome contributions to make this project out-of-this-galaxy! 🌠 To contribute:
1. Fork the repository.
2. Create a new branch (`git checkout -b feature/your-feature`).
3. Make your changes and commit (`git commit -m "Add your feature"`).
4. Push to your branch (`git push origin feature/your-feature`).
5. Open a pull request.

Please read our [Contributing Guide](CONTRIBUTING.md) for more details.

Have questions or suggestions? Open an [issue](https://github.com/username/star-wars-planets-stats/issues) 

## License
This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
