#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Poc1.Receiver.Api/Poc1.Receiver.Api.csproj", "Poc1.Receiver.Api/"]
RUN dotnet restore "Poc1.Receiver.Api/Poc1.Receiver.Api.csproj"
COPY . .
WORKDIR "/src/Poc1.Receiver.Api"
RUN dotnet build "Poc1.Receiver.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Poc1.Receiver.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Poc1.Receiver.Api.dll"]