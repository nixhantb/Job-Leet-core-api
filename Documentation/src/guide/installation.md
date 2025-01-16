## Job Leet Installation Guide

This installation guide will walk you through setting up Job Leet, configuring PostgreSQL, applying database migrations, and generating API documentation.
Prerequisites

Ensure you have the following installed:

- [.NET SDK](https://dotnet.microsoft.com/en-us/download)
- [PostgreSQL](https://www.postgresql.org/download/)
- [PgAdmin](https://www.pgadmin.org/download/)

### Manual setup (Localhost)

### Step 1: Set Up Configuration

Rename the configuration file:
Rename `appsettings.json` to `appsettings.Development.json` for development-specific settings.

**Configure the connection string:**
In appsettings.Development.json, update the ConnectionStrings section as per your database setting:

```
"ConnectionStrings": {
  "jobleetconnect": "Host=<HostName>;Database=<DBName>;Username=<UserName>;Password=<PW>;Port=5432"
}
```
**Example connection settings**

```
 "ConnectionStrings": {
    "jobleetconnect": "Host=localhost;Database=jobleet_temp;Username=admin;Password=password#123;Port=5432"
  }
```

### Step 2: Install and Start PostgreSQL

**Install PostgreSQL**
Manual Installation [Guide](https://www.postgresql.org/download/)

For Ubuntu / terminal

```
sudo apt update
sudo apt install postgresql postgresql-contrib
```

Start the PostgreSQL service:

```
sudo systemctl start postgresql

```

Generate Database Schema:

If you’d like to export the schema structure:

```
sudo -u postgres pg_dump -s -U postgres <DBName> > db_schema.sql

```
Note: Replace <DBName> with your database name.

### Step 3: Apply Database Migrations

In your ASP.NET project folder, Delete the Migration folder and run the following command

Install the .NET Entity Framework Core CLI globally to manage database migrations:

```
dotnet tool install --global dotnet-ef

dotnet ef migrations add InitialCreate

dotnet ef database update
```
### Step 4 

Run the dotnet application

From the root directory, Navigate to the `JobLeet.WebApi` folder
```
cd/JobLeet.WebApi

```

Build and Run the dotnet service

``` 

dotnet build && dotnet run

```

Access the web api into your brower with the following URLs

api service: `http://localhost:5184`

Swagger : `http://localhost:5184/swagger`


This setup provides the foundation for running Job Leet locally, with full database integration and API documentation capabilities. If you get any issues while installing, feel free to raise Issues in the main repository.
