# Fase base: Usada para o ambiente de produção
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

# Fase de build: Usada para compilar o projeto
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Verifique se o caminho está correto para o arquivo .csproj
COPY WebApiCoffeeShop/WebApiCoffeeShop.csproj WebApiCoffeeShop/

# Restaurar dependências do projeto
RUN dotnet restore WebApiCoffeeShop/WebApiCoffeeShop.csproj

# Copiar o restante do código-fonte
COPY . .

# Construir o projeto
WORKDIR /src/WebApiCoffeeShop
RUN dotnet build WebApiCoffeeShop.csproj -c $BUILD_CONFIGURATION -o /app/build

# Fase de publicação: Usada para preparar o aplicativo para produção
FROM build AS publish
RUN dotnet publish WebApiCoffeeShop.csproj -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Fase final: Usada para rodar a aplicação
FROM base AS final
WORKDIR /app

# Copiar os arquivos publicados da fase anterior
COPY --from=publish /app/publish .

# Definir o ponto de entrada para a aplicação
ENTRYPOINT ["dotnet", "WebApiCoffeeShop.dll"]
