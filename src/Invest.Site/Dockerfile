FROM microsoft/dotnet:3.0-aspnetcore-runtime-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:3.0-sdk-stretch AS build
WORKDIR /src
COPY ["src/Invest.Site/Invest.Site.csproj", "src/Invest.Site/"]
RUN dotnet restore "src/Invest.Site/Invest.Site.csproj"
COPY . .
WORKDIR "/src/src/Invest.Site"
RUN dotnet build "Invest.Site.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Invest.Site.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Invest.Site.dll"]