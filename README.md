# Meteostanice

Jednoduchá konzolová aplikace v .NET 10, která pravidelně stahuje data z meteorologické stanice, převádí je z XML do JSON a ukládá je do SQLite databáze `meteo.db`. Zároveň si zapisuje, zda byla stanice v daném okamžiku online nebo offline.

## Spuštění

1. Nainstalujte .NET 10 SDK.
2. Zkontrolujte `Meteostanice/appsettings.json` a případně upravte URL stanice nebo interval stahování.
3. V kořeni řešení spusťte:

```bash
dotnet run --project Meteostanice/Meteostanice.csproj
```

Databáze se vytvoří automaticky při prvním spuštění aplikace.