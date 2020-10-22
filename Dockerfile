#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim-arm32v7 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["RandomeWord.csproj", ""]
RUN dotnet restore "./RandomeWord.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "RandomeWord.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RandomeWord.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RandomeWord.dll"]