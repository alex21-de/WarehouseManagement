FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
LABEL author="Alexei Rotari"
LABEL version="1.0"

WORKDIR /src

# Copy csproj
COPY ../../WarehouseManagement.Web/WarehouseManagement.Web.csproj src/WarehouseManagement.Web/

# Restore
RUN dotnet restore src/WarehouseManagement.Web/WarehouseManagement.Web.csproj

#
COPY . .

WORKDIR /src/src/WarehouseManagement.Web

# Publish app
RUN dotnet publish -c Release -o /app/publish


FROM mcr.microsoft.com/dotnet/aspnet:9.0

WORKDIR /app

COPY --from=build /app/publish .

EXPOSE 8080

#ENV ASPNETCORE_URLS=http://+:8080

ENTRYPOINT ["dotnet", "WarehouseManagement.Web.dll"]