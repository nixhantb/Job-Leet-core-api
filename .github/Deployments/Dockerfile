FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

COPY JobLeet.WebApi/JobLeet.WebApi.sln .
COPY JobLeet.WebApi/JobLeet.WebApi.csproj ./JobLeet.WebApi/
COPY JobLeet.Tests/UnitTests/*.csproj ./JobLeet.Tests/UnitTests/

WORKDIR /src/JobLeet.WebApi
RUN dotnet restore JobLeet.WebApi.csproj

COPY JobLeet.WebApi/. .
RUN dotnet build -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
RUN dotnet publish -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

ENV ASPNETCORE_URLS="http://+:8080"

CMD ["dotnet", "JobLeet.WebApi.dll"]
