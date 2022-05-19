#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/api gateways/SE.Bff.Compras/SE.Bff.Compras.csproj", "src/api gateways/SE.Bff.Compras/"]
RUN dotnet restore "src/api gateways/SE.Bff.Compras/SE.Bff.Compras.csproj"
COPY . .
WORKDIR "/src/src/api gateways/SE.Bff.Compras"
RUN dotnet build "SE.Bff.Compras.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SE.Bff.Compras.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SE.Bff.Compras.dll"]