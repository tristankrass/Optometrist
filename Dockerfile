FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /app

# copy csproj and restore as distinct layers
COPY WebApp/*.csproj ./WebApp/
COPY utils/*.csproj ./utils/
WORKDIR /app/WebApp
RUN dotnet restore

# copy and publish app and libraries
WORKDIR /app/
COPY WebApp/. ./WebApp/
COPY utils/. ./utils/
WORKDIR /app/WebApp
RUN dotnet publish -c Release -o out


# test application -- see: dotnet-docker-unit-testing.md
FROM build AS testrunner
WORKDIR /app/tests
COPY tests/. .
ENTRYPOINT ["dotnet", "test", "--logger:trx"]


FROM mcr.microsoft.com/dotnet/core/runtime:3.1 AS runtime
WORKDIR /app
COPY --from=build /app/WebApp/out ./
ENTRYPOINT ["dotnet", "WebApp.dll"]