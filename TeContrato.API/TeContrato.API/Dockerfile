﻿FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 5000
ENV ASPNETCORE_URLS=http://*:5000

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["TeContrato.API/TeContrato.API.csproj", "TeContrato.API/"]
RUN dotnet restore "TeContrato.API/TeContrato.API.csproj"
COPY . .
WORKDIR "/src/TeContrato.API"
RUN dotnet build "TeContrato.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TeContrato.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "tecontrato.api.dll"]
#CMD ASPNETCORE_URLS=http://*:$PORT dotnet tecontrato.api.dll
