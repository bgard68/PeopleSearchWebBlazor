# BlazorAppWebSearchUsingAI

A Blazor application demonstrating Clean Architecture principles, modular design, and maintainable code structure.

---
## 📚 Documentation Links

- [Clean Architecture Analysis](README_CleanArchitecture.md)
- [Database Setup Guide](SETUP_DATABASE.md)

---

## Solution Overview

This solution is organized according to Clean Architecture, ensuring separation of concerns and maintainability.

### Layers

- **Presentation Layer:**  
  Blazor components such as `Home.razor`, `Analysis.razor`, `NavMenu.razor`, and `MainLayout.razor` handle UI and user interaction.

- **Application Layer:**  
  Contains business logic interfaces (e.g., `Application/Interfaces/IPeopleService.cs`).

- **Domain Layer:**  
  (Implied) Intended for core business entities and rules.

- **Infrastructure Layer:**  
  Handles data access and persistence (e.g., `Infrastructure/Data/DesignTimeDbContextFactory.cs`, `Infrastructure/Migrations/AppDbContextModelSnapshot.cs`).

---

## Key Architectural Principles

- **Dependency Rule:**  
  - Presentation depends on Application via dependency injection:  
    `@inject Application.Interfaces.IPeopleService PeopleService`
  - Application defines interfaces, not implementations, promoting inversion of control.
  - Infrastructure implements data access and is referenced by the application layer only through interfaces.

- **Separation of Concerns:**  
  - UI logic is kept in Blazor components.
  - Business logic is abstracted behind interfaces (`IPeopleService`).
  - Data access is isolated in the infrastructure layer.
  - Configuration is managed separately (`MessagesConfig.cs`, `appsettings.json`).

- **Dependency Injection:**  
  - Services are injected into components, decoupling implementation from usage.
  - Interfaces allow for easy swapping of implementations and facilitate testing.

- **Data Flow:**  
  - UI components interact with the application layer via injected services.
  - Application layer communicates with infrastructure for data retrieval and persistence.
  - Domain entities are used for data transfer between layers.

- **Maintainability & Testability:**  
  - Interfaces and separation of layers make the solution maintainable and testable.
  - Business logic can be tested independently of UI and data access.
  - Infrastructure can be replaced or mocked without affecting other layers.

---

## Getting Started

### Prerequisites

- Visual Studio 2022 (with "ASP.NET and web development" workload)
- .NET 8 SDK

### Build and Run

1. **Open the Solution:**  
   Launch Visual Studio 2022 and open `BlazorAppWebSearchUsingAI.sln`.

2. **Restore NuGet Packages:**  
   Visual Studio will restore packages automatically. If not, right-click the solution and select "Restore NuGet Packages".

3. **Build the Solution:**  
   Press `Ctrl+Shift+B` or use the "Build Solution" command.

4. **Run the Application:**  
   Set the Blazor project as the startup project, then press `F5` (debug) or `Ctrl+F5` (run without debugger).

---

## .gitignore Recommendation

To avoid committing build artifacts, add the following to your `.gitignore` file: