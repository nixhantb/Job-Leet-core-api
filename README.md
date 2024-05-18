# Job Leet - Job Portal API

Welcome to Job Leet, your go-to job portal powered by the Job Leet Job Portal API. This project is built using .NET 8, Docker and MySQL, providing a robust REST API for job-related functionalities.

Find the Frontend Development repository of this project [Here](https://github.com/Nix-code/Job-Leet-core-UI)

### Getting Started with Docker environment

Install 
[Docker](https://www.docker.com/get-started/)

1. Create `.env` file in the root directory 
   Fill the following information 

  ```bash
  MYSQL_DATABASE= DBName
  MYSQL_PASSWORD= StrongPassword

  ```
2. Rename `appsettings.json` to `appsettings.Development.json` 
  Replace the following informatoin

  ```bash
  "ConnectionStrings": {
      "jobleetconnect": "Server=sql_server;Database=<DBName>;User=<Username>;Password=<password>;Port=3306;AllowPublicKeyRetrieval=True;SslMode=None"
    },
  ```
3. Navigate to the `docker-compose.yml` and check the credentials; It should match the credentials of `jobleetconnect` 
Note: The credentials in `docker-compose.yml`, `.env` and `jobleetconnect` must match.

```bash
 environment:
      MYSQL_DATABASE: ${MYSQL_DATABASE}
      MYSQL_USER: leetadmin
      MYSQL_PASSWORD: ${MYSQL_PASSWORD}`
   ```
4. Final step 
```bash
docker-compose build && docker-compose up
```
and Access the service using 
```bash
http://localhost:8080/api/v1/<endpoint>
```

Or 

```bash
http://localhost:8080/swagger/index.html
```
## Table of Contents

- [Introduction](#job-leet---job-portal-api)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Clone and Build](#clone-and-build)
  - [Configuration](#configuration)
- [Database](#database)
- [Features](#features)
- [Issues](#issues)
- [Contribution](#contribution)
- [License](#license)
## Getting Started In local environment

### Prerequisites

Make sure you have the following installed on your system:
- [.NET 8](https://dotnet.microsoft.com/download/dotnet/8.0)
- [MySQL](https://www.mysql.com/) 
- [Docker](https://www.docker.com/get-started/)

### Clone and Build

Clone the repository:

```bash
git clone https://github.com/Nix-code/Job-Leet-core-api.git

```

Navigate to the project directory:

```cd Job-Leet-core-api```

Build the application:
```bash dotnet build```


### Configuration
Update the `appsettings.json` file with your MySQL database connection details. But we will be using `appsettings.Development.json` for our work.

### Database
Job Leet uses a MySQL database to store job-related data. You can configure the database connection settings in the appsettings.json file.

 #### Migrate the Database
 ```bash
 dotnet add package Microsoft.EntityFrameworkCore.Design

```

### Features
 - BaseAPIController
 - BaseDBContext
 - Input Validation
 - Data Validation
 - Database Migrations
 - Endpoints
 - Caching
 - Loggers
 - Authentication
 - Exceptions
 - SecurityHeaders
 - RateLimiter
 - Versioning
 - Jwt Tokens
 - Message Broker (RabbitMQ)
 - Documentations
 - Docker Container
 - CICD
 - Unit tests

### Issues
If you encounter any issues or have suggestions, feel free to open an issue [here](https://github.com/Nix-code/Job-Leet-core-api/issues)

### Contribution
We welcome contributions to make Job Leet even better! If you'd like to contribute, please follow the steps [here](CONTRIBUTION.md) 

### License
This project is licensed under the [MIT License](LICENSE). Feel free to explore, contribute, and use Job Leet according to the terms of the license.
