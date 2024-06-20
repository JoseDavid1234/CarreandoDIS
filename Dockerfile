# Utiliza la imagen base de .NET 8 SDK para construir la aplicación
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Establece el directorio de trabajo dentro del contenedor
WORKDIR /app

# Copia los archivos de la carpeta actual (contexto) al contenedor
COPY . .

# Asegúrate de que el archivo de proyecto .csproj exista en la ubicación correcta
# Asumiendo que CarreandoDIS.csproj está dentro de CarreandoDis/CarreandoDis
RUN ls -la CarreandoDis/CarreandoDis  # Comprueba que el archivo CarreandoDIS.csproj esté presente
RUN dotnet restore "CarreandoDis/CarreandoDis/CarreandoDIS.csproj"

# Genera la aplicación en modo Release (producción)
RUN dotnet build "CarreandoDis/CarreandoDis/CarreandoDIS.csproj" -c Release -o /app/build

# Publica la aplicación en un directorio listo para desplegar
RUN dotnet publish "CarreandoDis/CarreandoDis/CarreandoDIS.csproj" -c Release -o /app/publish

# Utiliza la imagen base de .NET 8 para ejecutar la aplicación publicada
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .

# Define el comando de inicio para ejecutar la aplicación cuando se inicie el contenedor
CMD ["dotnet", "CarreandoDIS.dll"]

