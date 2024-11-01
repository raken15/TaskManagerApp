# Task Manager App

# StockTradingApplication

## Overview


## Demo Showcase


## Table of Contents

- [Overview](#overview)
- [Demo Showcase](#demo-showcase)
- [Installation and Usage with Release Binary File](#installation-and-usage-with-release-binary-file)
  - [Prerequisites](#prerequisites)
  - [Installation Steps](#installation-steps)
- [Building and Running the Project](#building-and-running-the-project)
  - [Build and Runtime Prerequisites](#build-and-runtime-prerequisites)
  - [Building the Project](#building-the-project)
  - [Executing the Project Post-Build](#executing-the-project-post-build)
  - [Considerations for Running the Project Post-Build](#considerations-for-running-the-project-post-build)
- [Features](#features)
- [Architecture](#architecture)
  - [MVVM Pattern](#mvvm-pattern)
  - [Key Components](#key-components)
  - [Design and Code Improvements](#design-and-code-improvements)
- [Flow and Structure](#flow-and-structure)
  - [Application Flow](#application-flow)
  - [Commands and Controls](#commands-and-controls)
  - [Logging](#logging)
- [Tests](#tests)
- [Ideas for improvements in the future](#ideas-for-improvements-in-the-future)
- [Additional Documentation](#additional-documentation)
  - [Changelog](#changelog)
  - [Contributing](#contributing)
  - [License](#license)

## Installation and Usage with Release Binary File

### Prerequisites

- Windows operating system

### Installation Steps

1. Navigate to the **Releases** section of this project.
   - The latest release, **v1.0.0**, can be found [here](https://github.com/raken15/TaskManagerApp/releases/tag/v1.0.0).
2. Download the `TaskManager_v1.0.0.zip` file.
3. Extract the contents of the zip file.
5. Run the `TaskManager.exe` file.
6. Use the user interface (UI) to manage stock trading activities. Prices will update automatically, allowing you to monitor the performance of your financial portfolio.
7. The objective is to reach a winning amount of $10,000 (default) while avoiding a loss of $1 (default).

## Building and Running the Project

### Build and Runtime Prerequisites

- Visual Studio Code (or any text editor/IDE with C# support)
- .NET 8.0 SDK
- Windows operating system

### Building the Project

1. Clone the repository:
    ```bash
    git clone https://github.com/raken15/TaskManagerApp.git
    ```
   - Alternatively, you can click the green **Code** button on the project’s GitHub page to download as a zip file and extract it.
   
2. Navigate to the solution directory:
    ```bash
    cd TaskManagerApp
    ```
   - You may also use your file explorer to navigate to the solution folder.

3. Open the solution (`.sln` file) in Visual Studio Code or another compatible text editor/IDE.

4. Build the solution to restore all dependencies.

### Executing the Project Post-Build

1. Build the solution.
2. Execute the application either from Visual Studio Code or by running the executable (`.exe` file) located in the `bin` folder.
  
### Considerations for Running the Project Post-Build


## Features


## Architecture

The application follows the **MVVM architecture**. This design pattern enforces a clear separation of concerns, promoting a structured and maintainable codebase. 

### MVVM Pattern

- **Model**: Encapsulates business logic and data representation. Examples include `Category.cs` and `Task.cs`.
- **View**: Defines the UI using XAML. For instance, `MainView.xaml` is responsible for displaying the main user interface.
- **ViewModel**: Acts as a bridge between the Model and View. ViewModels like `MainViewModel` and `CategoryViewModel` expose data and commands to the View and handle user interaction logic.

### Key Components


### Design and Code Improvements


## Flow and Structure


### Application Flow


### Commands and Controls


### Logging


## Tests


### To run tests:

1. Navigate to the Tests directory:
    ```bash
    cd [path-to-solution]\Tests
    ```
    1. Alternatively navigate to the Tests folder using the file explorer [path-to-solution]\Tests

2. Run the tests using the .NET CLI:
    ```bash
    dotnet test
    ```
    1. Alternatively open the project in Visual Studio Code or any matching IDE and run the tests from the run tests button in there

3. Review the results to ensure all tests pass.

## Ideas for improvements in the future


## Additional Documentation

### Changelog
For a detailed list of changes, please see the [CHANGELOG.md](CHANGELOG.md).

### Contributing

If you want to contribute, please see the [CONTRIBUTING.md](CONTRIBUTING.md) for steps on how to do it.

### License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) for details.
