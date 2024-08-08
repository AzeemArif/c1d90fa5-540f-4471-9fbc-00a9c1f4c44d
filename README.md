# Longest Increasing Subsequence App

This is a console application that finds the longest increasing subsequence in a list of integers. The application is containerized using Docker for ease of deployment.

## Prerequisites
- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) installed
- [Docker](https://www.docker.com/products/docker-desktop) installed

## Building and Running the Application
### Clone the Repository

git clone https://github.com/AzeemArif/c1d90fa5-540f-4471-9fbc-00a9c1f4c44d.git
cd to the Application (longest-increasing-subsequence-app)

## Running Locally
1.	Restore the .NET packages: 
dotnet restore
2. Build the project:
dotnet build
3. RUn the application:
dotnet run --project LongestIncreasingSubsequenceApp Or dotnet run

### Running Tests
1. Run the tests
dotnet test

### Containerizing with Docker
1. Build Docker Image:
docker build -t longest-increasing-subsequence-app .
2. Run the Docker container:
docker run --rm -it longest-increasing-subsequence-app

##### Project Strcture:
	•	LongestIncreasingSubsequenceApp/: Contains the main application code.
	•	LongestIncreasingSubsequence.Tests/: Contains the unit tests for the application.

##### Example Usage
Run the application and enter space-separated integers to find the longest increasing subsequence, or type quit to exit:
Enter space-separated integers to find the longest increasing subsequence or type 'quit' to exit:
6 1 5 9 2
Longest Increasing Subsequence: 1 5 9