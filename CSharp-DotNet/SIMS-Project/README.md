# SIMS - Student Information Management System

## Introduction
**SIMS** (Student Information Management System) is an academic and student management platform built with **ASP.NET Core Blazor Server** (.NET 8.0) and **Entity Framework Core**, utilizing a **MySQL** database. The system is designed to support three primary roles: **Admin**, **Lecture**, and **Student**.

## Project Directory Structure

```text
SIMS/
├── Components/                 # Blazor UI Components
│   ├── Account/                # Authentication and identity management
│   ├── Layout/                 # Main application layout and navigation
│   └── Pages/                  # Main pages organized by roles
│       ├── AdminPages/         # Admin dashboard (Manage Courses, Departments, Grades, Schedules, Semesters, Subjects, Users, etc.)
│       ├── LecturePages/       # Lecture dashboard (Teaching schedules, Grading, Student lists, etc.)
│       ├── StudentPages/       # Student dashboard (Class schedules, Academic results, Enrolled courses, etc.)
│       ├── Auth.razor          # Authentication component
│       └── NotificationPage.razor # Notification management and viewing
├── Data/                       # Data Access Layer & Entities
│   ├── Migrations/             # EF Core Migrations files
│   ├── ApplicationDbContext.cs # Entity Framework DbContext for database configuration
│   ├── ApplicationUser.cs      # Custom user entity extending IdentityUser
│   ├── UserSeeder.cs           # Initial data seeding (Roles, default Admin account, etc.)
│   └── [Entities].cs           # System data models (Course, Department, Enrollment, Major, Subject, Schedule, Attendance, Notification, Semester)
├── Endpoints/                  # Minimal API Endpoints (e.g., StudentEndpoints)
├── Properties/                 # Application runtime properties (Debug/Release)
│   └── launchSettings.json     # Debug configurations, ports, and environment variables
├── wwwroot/                    # Static files directory
│   ├── bootstrap/              # Bootstrap CSS Framework
│   ├── css/                    # Custom application styles (app.css)
│   ├── uploads/                # Directory for user-uploaded files
│   └── favicon.png             # Application icon
├── appsettings.json            # Application configurations (Database connection strings, system settings, etc.)
├── Program.cs                  # Application entry point, Dependency Injection (DI) setup, Middlewares, and Identity configuration
└── SIMS.csproj                 # Project configuration file (.NET 8.0, NuGet Packages/Dependencies)
```

## Key Features

### 1. Authorization & Authentication
- Integrated with **ASP.NET Core Identity** for secure user management.
- Supports three distinct roles with specific permissions: `Admin`, `Lecture`, and `Student`.

### 2. Administrator (Admin)
- **Directory Management:** Manage Departments, Majors, Subjects, and Semesters.
- **Academic Management:** Create Classes/Courses and arrange class Schedules.
- **User Management:** Manage Lecture and Student accounts.
- **Student Affairs:** Handle course enrollments, grading records, and system-wide notifications.

### 3. Lecturer (Lecture)
- View assigned teaching schedules (`TeachingSchedule.razor`).
- Access class lists and enrolled students (`CourseStudents.razor`, `MyCourses.razor`).
- Manage grading and evaluate student performance (`Grading.razor`).

### 4. Student (Student)
- Track personal class schedules (`MySchedule.razor`).
- View grades and academic performance (`MyGrades.razor`).
- Review currently enrolled subjects and courses (`MyEnrollments.razor`).
- Keep track of academic notices and system announcements.

## Tech Stack
- **Framework:** .NET 8.0 (Blazor Server - Interactive Server Render Mode)
- **ORM:** Entity Framework Core 8.0
- **Database:** MySQL (via `Pomelo.EntityFrameworkCore.MySql` package)
- **UI Components/Styling:** Bootstrap 5.3, QuickGrid for Blazor
- **Reporting/Exporting:** ClosedXML (Excel)

## Installation and Setup Guide

1. **Database Configuration:** Open the `appsettings.json` file and update the `DefaultConnection` string to match your local MySQL configuration.
2. **Apply Database Migrations:** 
   Open your terminal in the root directory of the project (`SIMS/`) and run the following command to initialize the database:
   ```bash
   dotnet ef database update
   ```
3. **Run the Application:**
   Start the web server by running:
   ```bash
   dotnet run
   ```
4. **Data Seeding:** Upon the first launch, the `UserSeeder` class will automatically execute to generate the necessary roles (`Admin`, `Lecture`, `Student`) and prepare the authorization environment.