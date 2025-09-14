# Copilot Instructions for `baitapcaudk1`

## Project Overview
- This is a simple C# console application targeting .NET 8 (`net8.0`).
- The main logic is in `Program.cs`, which prompts the user for a numeric input and classifies it as a student grade category.
- No external dependencies or custom build steps are present; standard .NET SDK conventions are used.

## Key Files & Structure
- `Program.cs`: Contains the entry point and all business logic.
- `baitapcaudk1.csproj`: Defines project settings and target framework.
- `bin/` and `obj/`: Standard build output and intermediate files.

## Build & Run
- Build: Use `dotnet build` from the project root.
- Run: Use `dotnet run` from the project root to execute the console app.
- No custom scripts or test frameworks are present.

## Coding Patterns & Conventions
- All logic is currently in the `Main` method. If expanding, keep business logic in separate methods or classes for clarity.
- Input is read using `Console.ReadLine()` and converted to `Double`.
- Output is written using `Console.WriteLine()`.
- The current code uses `if`/`else` for grade classification. Note: The syntax in `Program.cs` has errors (e.g., stray semicolons, incorrect `Else` casing). Follow standard C# control flow syntax.

### Example: Grade Classification
```csharp
if (a >= 8)
{
    Console.WriteLine("Học sinh giỏi");
}
else if (a >= 6.5)
{
    Console.WriteLine("Học sinh khá");
}
else if (a >= 5)
{
    Console.WriteLine("Học sinh trung bình");
}
else
{
    Console.WriteLine("Chưa đạt");
}
```

## Git & Versioning
- Standard `.git` directory is present. No project-specific branching or commit conventions detected.

## Extending the Project
- For additional features, add new classes in the root directory and update `Program.cs` to use them.
- Follow .NET conventions for naming and organization.

## No Special Integration Points
- No external APIs, databases, or services are integrated.
- No custom configuration or environment variables required.

---

For questions or unclear conventions, review `Program.cs` and `baitapcaudk1.csproj` for current patterns. If expanding, document new conventions here.
