#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["./web/SE.WebApp.MVC/SE.WebApp.MVC.csproj", "web/SE.WebApp.MVC/"]
COPY ["./building blocks/SE.Core/SE.Core.csproj", "building blocks/SE.Core/"]
COPY ["./building blocks/SE.WebApi.Core/SE.WebApi.Core.csproj", "building blocks/SE.WebApi.Core/"]

RUN dotnet restore "web/SE.WebApp.MVC/SE.WebApp.MVC.csproj"
COPY . .
WORKDIR "web/SE.WebApp.MVC"
RUN dotnet build "SE.WebApp.MVC.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SE.WebApp.MVC.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SE.WebApp.MVC.dll"]