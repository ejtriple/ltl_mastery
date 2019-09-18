FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["LTLMastery.Web/LTLMastery.Web.csproj", "LTLMastery.Web/"]
RUN dotnet restore "LTLMastery.Web/LTLMastery.Web.csproj"
COPY . .
WORKDIR "/src/LTLMastery.Web"
RUN dotnet build "LTLMastery.Web.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "LTLMastery.Web.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "LTLMastery.Web.dll"]