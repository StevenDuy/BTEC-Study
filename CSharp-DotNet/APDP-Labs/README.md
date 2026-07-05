
---

### Readme for APDP main project

```markdown
# APDP — Course Project

## Overview
This is the main project for the Applied Programming and Design Principles (APDP) course. It demonstrates practical application of OOP, design patterns, and database-driven development using Entity Framework Core.

---

## Technologies used
- **IDE:** Visual Studio Community 2022
- **Language:** C#
- **Framework:** .NET 6.0
- **Database:** SQL Server
- **ORM:** Entity Framework Core (Code-First Migrations)

---

## Project structure
- **Models:** Entity classes representing database tables
- **Data/Migrations:** EF Core migration files
- **Controllers:** Business logic and data access
- **Views:** UI components (for MVC projects)
- **appsettings.json:** Configuration including database connection string

---

## Database setup
1. **Update connection string:** Edit `appsettings.json`:
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=SIMS_DB;Trusted_Connection=True;MultipleActiveResultSets=true"
     }
   }
