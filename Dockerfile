# Use the official .NET image as a parent image
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY LongestIncreasingSubsequenceApp/*.csproj ./LongestIncreasingSubsequenceApp/
COPY LongestIncreasingSubsequence.Tests/*.csproj ./LongestIncreasingSubsequence.Tests/
RUN dotnet restore ./LongestIncreasingSubsequenceApp/LongestIncreasingSubsequenceApp.csproj
RUN dotnet restore ./LongestIncreasingSubsequence.Tests/LongestIncreasingSubsequence.Tests.csproj

# Copy everything else and build
COPY . ./
RUN dotnet publish ./LongestIncreasingSubsequenceApp/LongestIncreasingSubsequenceApp.csproj -c Release -o out

# Run tests
RUN dotnet test ./LongestIncreasingSubsequence.Tests/LongestIncreasingSubsequence.Tests.csproj

# Build runtime image
FROM mcr.microsoft.com/dotnet/runtime:8.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "LongestIncreasingSubsequenceApp.dll"]