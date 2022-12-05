#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Unik_OnBoarding.Api/Unik_OnBoarding.Api.csproj", "Unik_OnBoarding.Api/"]
COPY ["Unik_OnBoarding.Application/Unik_OnBoarding.Application.csproj", "Unik_OnBoarding.Application/"]
COPY ["Unik_OnBoarding.Domain/Unik_OnBoarding.Domain.csproj", "Unik_OnBoarding.Domain/"]
COPY ["Unik_OnBoarding.Persistance.Migartions/Unik_OnBoarding.Persistance.User.Migartions.csproj", "Unik_OnBoarding.Persistance.Migartions/"]
COPY ["Unik_OnBoarding.User.Persistance/Unik_OnBoarding.User.Persistance.csproj", "Unik_OnBoarding.User.Persistance/"]
COPY ["Unik_OnBoarding.Persistance/Unik_OnBoarding.Persistance.csproj", "Unik_OnBoarding.Persistance/"]
COPY ["Unik_OnBoaring.SqlServerContext.Mirgrations/Unik_OnBoaring.SqlServerContext.Mirgrations.csproj", "Unik_OnBoaring.SqlServerContext.Mirgrations/"]
COPY ["Unik_OnBoaring.SqlServerContext/Unik_OnBoaring.SqlServerContext.csproj", "Unik_OnBoaring.SqlServerContext/"]
RUN dotnet restore "Unik_OnBoarding.Api/Unik_OnBoarding.Api.csproj"
COPY . .
WORKDIR "/src/Unik_OnBoarding.Api"
RUN dotnet build "Unik_OnBoarding.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Unik_OnBoarding.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Unik_OnBoarding.Api.dll"]