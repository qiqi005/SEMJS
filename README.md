# SEMJS - University Student Job Search & Matching Platform

SEMJS is a full-stack Web application developed with ASP.NET Core C# and Entity Framework (EF) Core, designed to bridge university students with employers through intelligent skill matching, dynamic dynamic resumes and real-time application tracking.

## Tech Stack & Architecture
- **Framework**: ASP.NET Core (Razor Pages)
- **Language**: C# / .NET
- **Database**: SQL Server / MySQL (Entity Framework Core Code-First Migrations)
- **Design & UI**: Bootstrap, CSS3, JavaScript, Figma
- **Tools**: RESTful API Patterns, Postman, Git

## Key Features & Technical Highlights
- **Role-Based Workflows**: Tailored Razor Page dashboards for Students, Employers, and System Administrators.
- **Rule-Based Matching Engine (`MatchEngine.cs`)**: Automated matching algorithm calculating candidate suitability scores based on required job skills vs. student profile interests.
- **Dynamic Resume & Skill Extraction**: Automated parsing of student skills (`ResumeSkillExtractor.cs`) and dynamic portfolio items generation.
- **Full Database Migrations**: Normalized relational schema implemented via EF Core Code-First (`ApplicationDbContext`), supporting student activities, application messages, and skill catalogues.
