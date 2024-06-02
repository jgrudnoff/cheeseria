#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["cheeseria.client/nuget.config", "cheeseria.client/"]
COPY ["cheeseria.Server/cheeseria.Server.csproj", "cheeseria.Server/"]
COPY ["cheeseria.client/cheeseria.client.esproj", "cheeseria.client/"]
RUN dotnet restore "./cheeseria.Server/cheeseria.Server.csproj"
COPY . .
WORKDIR "/src/cheeseria.Server"
RUN dotnet build "./cheeseria.Server.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./cheeseria.Server.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "cheeseria.Server.dll"]