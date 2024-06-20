
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build


WORKDIR /app


COPY . .


RUN dotnet restore "CarreandoDis/CarreandoDIS.csproj"


RUN dotnet build "CarreandoDis/CarreandoDIS.csproj" -c Release -o /app/build


RUN dotnet publish "CarreandoDis/CarreandoDIS.csproj" -c Release -o /app/publish


FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .


CMD ["dotnet", "CarreandoDIS.dll"]
