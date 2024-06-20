# Utiliza la imagen base de .NET 8 SDK para construir la aplicación
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Establece el directorio de trabajo dentro del contenedor
WORKDIR /app

# Copia los archivos de la carpeta actual (contexto) al contenedor
COPY . .

# Asegúrate de que el archivo de proyecto .csproj exista en la ubicación correcta
# Revisa la estructura de carpetas y ajusta la ruta según sea necesario
RUN ls -la  # Listar el contenido para verificar la estructura actual
RUN ls -la CarreandoDis  # Comprueba si la carpeta CarreandoDis está presente
RUN ls -la CarreandoDis/CarreandoDIS  # Comprueba si la carpeta CarreandoDis/CarreandoDIS está presente

# Ejecuta dotnet restore, build y publish
RUN dotnet restore "CarreandoDis/CarreandoDIS.csproj"
RUN dotnet build "CarreandoDis/CarreandoDIS.csproj" -c Release -o /app/build
RUN dotnet publish "CarreandoDis/CarreandoDIS.csproj" -c Release -o /app/publish

# Utiliza la imagen base de .NET 8 para ejecutar la aplicación publicada
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .

# Define el comando de inicio para ejecutar la aplicación cuando se inicie el contenedor
CMD ["dotnet", "CarreandoDIS.dll"]


