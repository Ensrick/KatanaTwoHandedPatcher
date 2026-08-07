# Contributing

Keep changes deterministic and compatible with headless Synthesis execution.
Before opening a pull request, run:

```powershell
dotnet restore --locked-mode
dotnet build --configuration Release --no-restore
```

Do not add Bethesda assets, third-party mod assets, generated plugins, or local
load-order data to this repository.
