
# Define the base image with ASP.NET runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /src
# Expose port 8080 to allow external access
EXPOSE 8080

# Define the build image with .NET Core SDK
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

COPY JobLeet.WebApi/JobLeet.WebApi.sln .
COPY JobLeet.WebApi/JobLeet.WebApi.csproj ./JobLeet.WebApi/
COPY JobLeet.Tests/UnitTests/*.csproj ./JobLeet.Tests/UnitTests/

WORKDIR /src/JobLeet.WebApi
RUN dotnet restore JobLeet.WebApi.csproj

COPY JobLeet.WebApi/. .
WORKDIR "/src/JobLeet.WebApi"
RUN dotnet build -c $BUILD_CONFIGURATION -o /app/build

# Define a stage for publishing the application
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
# Copy the published application from the 'publish' stage to the current directory
COPY --from=publish /app/publish .

# Set the ASP.NET Core URLs environment variable
ENV ASPNETCORE_URLS="http://+:8080"

# Run the application
CMD ["dotnet", "JobLeet.WebApi.dll"]
