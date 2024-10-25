# Base image with ASP.NET Core runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080

# Build image with .NET SDK
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Copy the solution and project files
COPY JobLeet.WebApi/JobLeet.WebApi.sln .
COPY JobLeet.WebApi/JobLeet.WebApi.csproj ./JobLeet.WebApi/
COPY JobLeet.Tests/UnitTests/*.csproj ./JobLeet.Tests/UnitTests/

# Restore dependencies
WORKDIR /src/JobLeet.WebApi
RUN dotnet restore JobLeet.WebApi.csproj

# Copy the application source code and build it
COPY JobLeet.WebApi/. .
RUN dotnet build -c $BUILD_CONFIGURATION -o /app/build

# Publish the application
FROM build AS publish
RUN dotnet publish -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Use the base image to run the application
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

# Set environment variables
ENV ASPNETCORE_URLS="http://+:8080"

# Start the application
CMD ["dotnet", "JobLeet.WebApi.dll"]
