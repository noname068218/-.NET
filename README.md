# .NET patterns

This repository is the contents of the **`.net paterns`** folder: patterns and SOLID samples.

## Layout

| Path | Description |
|------|-------------|
| `DotNetPatterns.sln` | Root solution (open this in Visual Studio / Rider / VS Code). |
| `Solid/` | Console app with SOLID examples (SRP, Open/Closed, Liskov samples). |
| `Builder/` | Reserved for Builder pattern samples. |
| `Factories/` | Reserved for Factory pattern samples. |

Build or run the console app:

```bash
dotnet build DotNetPatterns.sln
dotnet run --project Solid/Solid.csproj
```

`bin/`, `obj/`, and IDE folders are ignored via `.gitignore` (generated output is not committed).
