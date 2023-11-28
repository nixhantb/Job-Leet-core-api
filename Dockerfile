# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /source

# Copy solution and project files and restore dependencies
COPY *.sln .
COPY JobLeet.WebApi/*.csproj ./JobLeet.WebApi/
RUN dotnet restore

# Copy the source code, build, and publish the application
COPY . .
RUN dotnet publish -c Release -o /publish

# Stage 2: Create the final image
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS runtime
WORKDIR /app

# Copy the compiled and published application from the build stage
COPY --from=build /publish ./

# Set the entry point for the container
ENTRYPOINT ["dotnet", "JobLeet.WebApi.dll"]
