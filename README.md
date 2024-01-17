# Inventor_API

This repository contains a simple C# program using the Inventor API to add a button in a Windows Form. The button's functionality is to hide selected components in an active Assembly document.

## Usage

### Prerequisites
- Autodesk Inventor must be installed on your machine.
- This program is written in C# and uses the Windows Forms application framework.

### Instructions
1. Open the solution in Visual Studio.
2. Build the solution to ensure all dependencies are resolved.
3. Run the program.

Upon running the program, a Windows Form will appear with a button labeled "button1". Clicking this button will hide selected components in the active Assembly document.

**Note:** Ensure that you have an Assembly document open, and at least one part or sub-assembly is selected before clicking the button.

## Code Overview

### Form1.cs
- This file contains the main logic for the Windows Form application.
- It interacts with the Inventor API to hide selected components in an Assembly document.

### Form1.Designer.cs
- This file contains the auto-generated code for the Windows Form's design.
