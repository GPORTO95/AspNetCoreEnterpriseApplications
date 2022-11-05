#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["./services/SE.Pagamentos.API/SE.Pagamentos.API.csproj", "services/SE.Pagamentos.API/"]
COPY ["./building blocks/SE.Core/SE.Core.csproj", "building blocks/SE.Core/"]
COPY ["./building blocks/SE.WebApi.Core/SE.WebApi.Core.csproj", "building blocks/SE.WebApi.Core/"]
COPY ["./building blocks/SE.MessageBus/SE.MessageBus.csproj", "building blocks/SE.MessageBus/"]

RUN dotnet restore "services/SE.Pagamentos.API/SE.Pagamentos.API.csproj"
COPY . .
WORKDIR "services/SE.Pagamentos.API"
RUN dotnet build "SE.Pagamentos.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SE.Pagamentos.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SE.Pagamentos.API.dll"]