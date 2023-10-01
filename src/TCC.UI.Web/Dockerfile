#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/TCC.UI.Web/TCC.UI.Web.csproj", "src/TCC.UI.Web/"]
COPY ["src/TCC.Application/TCC.Application.csproj", "src/TCC.Application/"]
COPY ["src/TCC.Domain/TCC.Domain.csproj", "src/TCC.Domain/"]
COPY ["src/TCC.Infra.CrossCutting.Identity/TCC.Infra.CrossCutting.Identity.csproj", "src/TCC.Infra.CrossCutting.Identity/"]
COPY ["src/TCC.Infra.Data/TCC.Infra.Data.csproj", "src/TCC.Infra.Data/"]
COPY ["src/TCC.Infra.CrossCutting.IoC/TCC.Infra.CrossCutting.IoC.csproj", "src/TCC.Infra.CrossCutting.IoC/"]
RUN dotnet restore "src/TCC.UI.Web/TCC.UI.Web.csproj"
COPY . .
WORKDIR "/src/src/TCC.UI.Web"
RUN dotnet build "TCC.UI.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TCC.UI.Web.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TCC.UI.Web.dll"]