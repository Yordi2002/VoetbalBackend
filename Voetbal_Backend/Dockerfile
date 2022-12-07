#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Voetbal_Backend.csproj", "Voetbal_Backend/"]
RUN dotnet restore "Voetbal_Backend.csproj"
COPY . .
WORKDIR "/src/Voetbal_Backend"
RUN dotnet build "Voetbal_Backend.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Voetbal_Backend.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Voetbal_Backend.dll"]