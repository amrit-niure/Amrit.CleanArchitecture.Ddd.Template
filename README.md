# Clean Architecture + DDD (6-layer) .NET Template

A `dotnet new` template that scaffolds a full 6-layer Clean Architecture / Domain-Driven
Design solution for .NET:

- **Domain** — entities, value objects, domain events (no outward dependencies)
- **Application** — use cases / CQRS, depends on Domain + Shared
- **Infrastructure** — external services, depends on Application + Domain + Shared
- **Persistence** — EF Core, data access, depends on Application + Domain + Shared
- **Presentation** — UI-facing contracts/view models (class library, framework-agnostic), depends on Application + Shared
- **WebAPI** — ASP.NET Core Web API composition root with [Scalar](https://scalar.com/) API reference UI, depends on Application + Infrastructure + Persistence + Shared
- **Shared** — cross-cutting kernel, no dependencies

Each layer has a matching xUnit test project under `tests/`.

## Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) matching the template's target framework (`net10.0`)

## Install

```bash
git clone https://github.com/amrit-niure/Amrit.CleanArchitecture.Ddd.Template.git
dotnet new install ./Amrit.CleanArchitecture.Ddd.Template
```

## Use

```bash
dotnet new ddd-clean -n YourProjectName -o path/to/new/folder
```

Every occurrence of `Blank` in file names, folder names, and file contents (project
references, the `.slnx`, namespaces) is replaced with `YourProjectName`.

Then:

```bash
cd path/to/new/folder
dotnet run --project src/WebAPI
```

This opens the [Scalar](https://scalar.com/) API reference UI automatically in your browser.

## Update the template after making local changes

```bash
dotnet new install ./Amrit.CleanArchitecture.Ddd.Template
```

Re-running `install` on the same path updates the registered template in place.

## Uninstall

```bash
dotnet new uninstall ./Amrit.CleanArchitecture.Ddd.Template
```

## License

[MIT](LICENSE)
