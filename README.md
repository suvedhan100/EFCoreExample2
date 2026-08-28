# Entity Framework Core — CRUD Example

A focused example of Entity Framework Core (EF Core) used for data access in a C# application — covering CRUD operations, query patterns, and query optimization basics.

## Why this pattern matters
I've used EF Core (and raw SQL Server optimization) in production systems handling 1M+ record datasets, improving report generation speed by 50%+ through better query design. This repo isolates the core data-access patterns I rely on.

## What it demonstrates
- DbContext and entity model configuration
- CRUD operations (Create, Read, Update, Delete) via EF Core
- Query optimization techniques (projections, `AsNoTracking`, indexed lookups)
- Migrations for schema versioning

## Tech
C# · .NET · Entity Framework Core · SQL Server

## Run it
1. Update the connection string in `appsettings.json`
2. Apply migrations: `dotnet ef database update`
3. Run the app: `dotnet run`
4. Explore the CRUD endpoints/methods in `Program.cs` or the relevant service class
