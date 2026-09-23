FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /App

# Copy everything
COPY . ./

# Restore as distinct layers
RUN dotnet restore

# Run linting check
RUN dotnet format --verify-no-changes

# Run tests and collect coverage
RUN dotnet test --no-restore --collect:"XPlat Code Coverage"

# Build and publish a release
RUN dotnet publish App/App.csproj -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/runtime:8.0
WORKDIR /App
COPY --from=build-env /App/out .
ENTRYPOINT ["dotnet", "App.dll"]
