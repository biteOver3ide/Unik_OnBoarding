#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Unik_OnBoarding.WebApp/Unik_OnBoarding.WebApp.csproj", "Unik_OnBoarding.WebApp/"]
COPY ["Unik_OnBoarding.Persistance.Migartions/Unik_OnBoarding.Persistance.User.Migartions.csproj", "Unik_OnBoarding.Persistance.Migartions/"]
COPY ["Unik_OnBoarding.User.Persistance/Unik_OnBoarding.User.Persistance.csproj", "Unik_OnBoarding.User.Persistance/"]
RUN dotnet restore "Unik_OnBoarding.WebApp/Unik_OnBoarding.WebApp.csproj"
COPY . .
WORKDIR "/src/Unik_OnBoarding.WebApp"
RUN dotnet build "Unik_OnBoarding.WebApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Unik_OnBoarding.WebApp.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Unik_OnBoarding.WebApp.dll"]