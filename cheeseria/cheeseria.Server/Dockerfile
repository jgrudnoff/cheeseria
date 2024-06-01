#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["cheeseria.Server/cheeseria.Server.csproj", "cheeseria.Server/"]
RUN dotnet restore "./cheeseria.Server/cheeseria.Server.csproj"
COPY . .
WORKDIR "/src/cheeseria.Server"
RUN dotnet build "./cheeseria.Server.csproj" -c %BUILD_CONFIGURATION% -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./cheeseria.Server.csproj" -c %BUILD_CONFIGURATION% -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "cheeseria.Server.dll"]


#
#FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
#WORKDIR /App
#
## Copy everything
#COPY . ./
## Restore as distinct layers
#RUN dotnet restore
## Build and publish a release
#RUN dotnet publish -c Release -o out
#
## Build runtime image
#FROM mcr.microsoft.com/dotnet/aspnet:8.0
#WORKDIR /App
#COPY --from=build-env /App/out .
#ENTRYPOINT ["dotnet", "cheeseria.Server.dll"]
#