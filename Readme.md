# .NET Console Applications Playground

A collection of basic .NET Console Applications built to learn and practice C# programming concepts.

---

## 📂 Repository Structure

Below are the details of the projects included in this workspace:

### 1. [first Project](file:///c:/Users/pc/Desktop/dotnet/first)
A simple introductory console application.
* **Source Code**: [first/Program.cs](file:///c:/Users/pc/Desktop/dotnet/first/Program.cs)
* **Project File**: [first/first.csproj](file:///c:/Users/pc/Desktop/dotnet/first/first.csproj)
* **Goal**: Greets the user ("Hello! My name is Dipesh") and waits for a key press to terminate.

### 2. [variable Project](file:///c:/Users/pc/Desktop/dotnet/variable)
An application demonstrating variables and basic arithmetic.
* **Source Code**: [variable/Program.cs](file:///c:/Users/pc/Desktop/dotnet/variable/Program.cs)
* **Project File**: [variable/variable.csproj](file:///c:/Users/pc/Desktop/dotnet/variable/variable.csproj)
* **Goal**: Demonstrates integer declaration, summation of two variables, and outputting the result.

---

## 🛠️ Getting Started

### Prerequisites
Make sure you have the **.NET SDK** installed. You can verify your installation by running:
```bash
dotnet --version
```

### Running the Projects
You can run any project directly from the root directory using the `--project` flag:

To run the **first** project:
```bash
dotnet run --project first
```

To run the **variable** project:
```bash
dotnet run --project variable
```

Alternatively, navigate into a project folder and run:
```bash
cd first
dotnet run
```

---

## 📄 Git Configuration

A custom [.gitignore](file:///c:/Users/pc/Desktop/dotnet/.gitignore) has been added to exclude build artifacts (`bin/`, `obj/`), IDE/editor configurations (`.vs/`, `.vscode/`, `.idea/`), and system files from being tracked by Git.