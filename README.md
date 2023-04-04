## StarCitizen Keybinding Updater
### Overview
The StarCitizen Keybinding Updater is a Windows Forms application that allows users to update their StarCitizen keybindings across multiple game environments (Live and PTU). The application provides a user-friendly interface to backup, manage, and update the keybinding files.

### Dependencies
The code uses the following namespaces:

- `System.Diagnostics`
- `System.Xml`

### Class Form1
The main class of the application is `Form1`, which inherits from the `Form` class. It contains the following properties:

- `backupLocation`: Stores the file path of the backup keybinding file.
- `liveLocation`: Stores the file path of the Live environment keybinding file.
- `ptuLocation`: Stores the file path of the PTU environment keybinding file.
- `backupStoragePath`, `liveStoragePath`, `ptuStoragePath`: Stores the file paths of the text files containing the keybinding file locations.

### Methods
The class contains the following methods:

- `Form1()`: The constructor initializes the form and calls `CreateIfDoesntExist()`, `ReadFile()` for each file path, and `updateLocationLabelText()`.
- `updateLocationLabelText()`: Updates the text labels to display the current file paths.
- `CreateIfDoesntExist()`: Creates the text files to store the keybinding file paths if they don't already exist.
- `setFileLocation(string, string)`: Sets the file location based on the input path and line.
- `ReadFile(string)`: Reads the contents of a text file and calls `setFileLocation()` to update the file locations.
- `WriteToFile(string, string)`: Writes a message to a text file and updates the corresponding file location.
- `BrowseButton_Click()`, `browseLiveButton_Click()`, `browsePtuButton_Click()`: Event handlers for browsing and selecting keybinding files.
- `UpdateLiveButton_Click()`, `UpdatePtuButton_Click()`: Event handlers for updating the Live and PTU keybinding files.
- `ClearOutcomeLabel()`: Clears the outcome label text.
- `ClearLocationButton_Click()`, `ClearLiveButton_Click()`, `ClearPtuButton_Click()`: Event handlers for clearing the file paths.

### Usage

1. Build and run the application.
2. Browse and select the keybinding files for each environment (Backup, Live, and PTU) using the corresponding "Browse" buttons.
3. Click the "Update Live" or "Update PTU" button to update the keybindings in the respective environment.
4. To clear a file path, click the "Clear" button next to the corresponding file path.
5. The application will display a success message when the keybindings are updated successfully.
