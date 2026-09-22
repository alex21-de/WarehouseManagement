FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
LABEL author="Alexei Rotari"
LABEL version="1.0"

WORKDIR /src

# Copy csproj
COPY ../WarehouseManagement.API/WarehouseManagement.API.csproj src/WarehouseManagement.API/
COPY ../WarehouseManagement.Application/WarehouseManagement.Application.csproj src/WarehouseManagement.Application/
COPY ../WarehouseManagement.Domain/WarehouseManagement.Domain.csproj src/WarehouseManagement.Domain/
COPY ../WarehouseManagement.Infrastructure/WarehouseManagement.Infrastructure.csproj src/WarehouseManagement.Infrastructure/

# Restore
RUN dotnet restore src/WarehouseManagement.API/WarehouseManagement.API.csproj

#
COPY . .

WORKDIR /src/src/WarehouseManagement.API

# Publish app
RUN dotnet publish -c Release -o /app/publish


FROM mcr.microsoft.com/dotnet/aspnet:9.0

WORKDIR /app

COPY --from=build /app/publish .

EXPOSE 8080

#ENV ASPNETCORE_URLS=http://+:8080

ENTRYPOINT ["dotnet", "WarehouseManagement.API.dll"]