# Meteostanice

Jednoduchá konzolová aplikace v .NET 10, která pravidelně stahuje data z meteorologické stanice, převádí je z XML do JSON a ukládá je do SQLite databáze `meteo.db`. Zároveň si zapisuje, zda byla stanice v daném okamžiku online nebo offline.

## Požadavky

- .NET 10 SDK

## Konfigurace

Nastavení aplikace se nachází v `Meteostanice/appsettings.json`.

Lze měnit:

- URL meteorologické stanice (`Station:Url`)
- interval stahování v minutách (`Station:IntervalMinutes`)
- Název .db souboru (`ConnectionStrings:Default`)

## Spuštění

V kořeni řešení spusťte:

```bash
dotnet run --project Meteostanice/Meteostanice.csproj
```

Databáze se vytvoří automaticky při prvním spuštění aplikace.

## Použité technologie

- .NET 10
- Entity Framework Core
- SQLite
- System.Text.Json
- XmlSerializer