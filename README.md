# CleanArchTemplateASP.NET-CORE

CleanArchTemplate is a custom template designed to quickly scaffold an ASP.NET Core application with a clean architecture. It is intended for developers who want to start new projects with a predefined structure while following best practices in software design.

This template is a personal project and may undergo changes and improvements over time as I gain more experience in clean architecture.

---

## Features
- **Clean Architecture**: Separate projects for Core, Application, Infrastructure, and WebApi.
- **Pre-configured Structure**: The template includes commonly used configurations and dependencies.
- **Extensible**: Add your custom logic without worrying about initial project setup.

---

## Installation

### 1. Install the Template
To install the CleanArchTemplate package, navigate to the directory containing the template files and run:

```bash
dotnet new install ./
```

### 2. Overwrite an Existing Package
If you have previously installed this template and want to update it, use:

```bash
dotnet new install --force ./
```

---

## Usage

To create a new project using this template, run the following command:

```bash
dotnet new cleanarch -n "YourProjectName"
```

This will generate a new ASP.NET Core application with the following structure:

```
YourProjectName/
├── YourProjectName.Core
├── YourProjectName.Application
├── YourProjectName.Infrastructure
├── YourProjectName.WebApi
└── YourProjectName.sln
```

Each folder represents a layer of the clean architecture pattern:
- **Core**: Contains domain models and interfaces.
- **Application**: Contains application logic and services.
- **Infrastructure**: Implements data access and external dependencies.
- **WebApi**: Serves as the entry point of the application.

---

## Requirements

- .NET SDK 7.0 or later
- Familiarity with clean architecture principles is recommended but not required.

---

## Contributions

This project is primarily for personal use, but suggestions and contributions are welcome! Feel free to fork the repository and create a pull request with your improvements.

---

## Known Issues

- The template is still in development and may not cover all edge cases.
- Some configurations might require manual adjustments depending on your project requirements.

---

## License

This project is open-source and available under the MIT License. See the LICENSE file for more details.

---

### Example Workflow

1. **Install Template**:
   ```bash
   dotnet new install ./
   ```

2. **Create New Project**:
   ```bash
   dotnet new cleanarch -n "MyNewProject"
   ```

3. **Open Solution**:
   Navigate to the generated folder and open the solution file:
   ```bash
   cd MyNewProject
   code MyNewProject.sln
   ```

4. **Run the Application**:
   Build and run the project using:
   ```bash
   dotnet run --project MyNewProject.WebApi
   ```

Now you have a fully functional project with a clean architecture setup!