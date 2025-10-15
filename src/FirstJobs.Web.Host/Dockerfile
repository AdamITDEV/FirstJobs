FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src
COPY ["src/FirstJobs.Web.Host/FirstJobs.Web.Host.csproj", "src/FirstJobs.Web.Host/"]
COPY ["src/FirstJobs.Web.Core/FirstJobs.Web.Core.csproj", "src/FirstJobs.Web.Core/"]
COPY ["src/FirstJobs.Application/FirstJobs.Application.csproj", "src/FirstJobs.Application/"]
COPY ["src/FirstJobs.Core/FirstJobs.Core.csproj", "src/FirstJobs.Core/"]
COPY ["src/FirstJobs.EntityFrameworkCore/FirstJobs.EntityFrameworkCore.csproj", "src/FirstJobs.EntityFrameworkCore/"]
WORKDIR "/src/src/FirstJobs.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/FirstJobs.Web.Host", "src/FirstJobs.Web.Host"]
COPY ["src/FirstJobs.Web.Core", "src/FirstJobs.Web.Core"]
COPY ["src/FirstJobs.Application", "src/FirstJobs.Application"]
COPY ["src/FirstJobs.Core", "src/FirstJobs.Core"]
COPY ["src/FirstJobs.EntityFrameworkCore", "src/FirstJobs.EntityFrameworkCore"]
WORKDIR "/src/src/FirstJobs.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "FirstJobs.Web.Host.dll"]
