# .NET Joke Service2 Installation Guide

## Command-Line Installation and Uninstallation

### Prerequisites
- Ensure you have the WiX Toolset installed.
- Ensure you have administrative privileges to run the commands.

### Steps to Install

1. **Navigate to the project directory**:
    `# .NET Joke Service2 Installation Guide

## Command-Line Installation and Uninstallation

### Prerequisites
- Ensure you have the WiX Toolset installed.
- Ensure you have administrative privileges to run the commands.

### Steps to Install

1. **Navigate to the project directory**:
    `cd .NET-Joke-Service2\JokeService2\JokeService2.Installer`

    
2. **Build the WiX project** to generate the `.msi` file:
    `dotnet build Joke\ Installer.wixproj -c Release`

    
3. **Run the silent installation**:
    `msiexec /i JokeService2Installer.msi /quiet`

    
### Steps to Uninstall

1. **Run the silent uninstallation**:
    `msiexec /x JokeService2Installer.msi /quiet`

    

## Point-and-Click Installation and Uninstallation

### Installation

1. **Locate the `.msi` file**:
    - Navigate to the directory where your `.msi` file is located using File Explorer.

2. **Run the installer**:
    - Double-click the `.msi` file.
    - Follow the on-screen instructions to complete the installation.

### Uninstallation

1. **Open Settings**:
    - Press `Win + I` to open the Settings app.
    - Alternatively, you can click on the Start menu and select `Settings`.

2. **Navigate to Apps**:
    - In the Settings window, click on `Apps`.

3. **Find the Application**:
    - In the `Apps & features` section, scroll through the list or use the search bar to find the application (e.g., ".NET Joke Service2").

4. **Uninstall the Application**:
    - Click on the application name to expand the options.
    - Click the `Uninstall` button.
    - Confirm any prompts to proceed with the uninstallation.

### Notes
- Ensure you have administrative privileges to install or uninstall the application.
- For silent installations and uninstallations, use the command-line method.
