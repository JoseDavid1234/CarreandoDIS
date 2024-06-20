# Utiliza la imagen base de .NET 8 SDK para construir la aplicación
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Establece el directorio de trabajo dentro del contenedor
WORKDIR /app

# Copia los archivos de la carpeta actual (contexto) al contenedor
COPY . .

# Verifica la estructura de carpetas copiadas
RUN ls -la

# Asegúrate de que la carpeta CarreandoDis esté presente
RUN ls -la CarreandoDIS

# Ejecuta dotnet restore, build y publish
RUN dotnet restore CarreandoDIS/CarreandoDIS.csproj
RUN dotnet build CarreandoDIS/CarreandoDIS.csproj -c Release -o /app/build
RUN dotnet publish CarreandoDIS/CarreandoDIS.csproj -c Release -o /app/publish

# Utiliza la imagen base de .NET 8 para ejecutar la aplicación publicada
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .

# Define el comando de inicio para ejecutar la aplicación cuando se inicie el contenedor
CMD ["dotnet", "CarreandoDIS.dll"]


