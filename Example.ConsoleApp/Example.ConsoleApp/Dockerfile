# docker build context point is the CacheLine.CPU.SCU, not Example.ConsoleApp

FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Example.ConsoleApp/Example.ConsoleApp/Example.ConsoleApp.csproj", "Example.ConsoleApp/Example.ConsoleApp/"]
COPY ["CacheLine.CPU.SCU/CacheLine.CPU.SCU.csproj", "CacheLine.CPU.SCU/"]
RUN dotnet restore "./Example.ConsoleApp/Example.ConsoleApp/Example.ConsoleApp.csproj"
COPY . .
WORKDIR "/src/Example.ConsoleApp/Example.ConsoleApp"
RUN dotnet build "./Example.ConsoleApp.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Example.ConsoleApp.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Example.ConsoleApp.dll"]
