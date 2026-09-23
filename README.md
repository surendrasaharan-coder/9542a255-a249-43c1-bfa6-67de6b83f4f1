# Coding Test Solution

This repository contains the solution for the "Longest Contiguous Increasing Subsequence" coding test. It is implemented in C# .NET.

## Project Structure
- `App/` - Core logic (`Solver.cs`) and entry point containing the algorithm to find the longest increasing contiguous subsequence.
- `Tests/` - xUnit project containing the provided test cases.

## Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)

## How to Verify Solution

### 1. Build the solution
Navigate to the root directory and run:
`dotnet build`

### 2. Code Linting
To check if the code adheres to the defined `.editorconfig` rules, run:
`dotnet format --verify-no-changes`

### 3. Run Unit Tests
To run the automated test cases and verify the exact output matching the required problem statement, run:
`dotnet test`

### 4. Code Coverage
To run tests and generate a code coverage report for the core logic, use:
`dotnet test --collect:"XPlat Code Coverage"`
This produces `coverage.cobertura.xml` within `Tests/TestResults`.

## Continuous Integration & Containerization

### Docker Containerization
The solution is fully containerised and the build runs within the container (including checks and tests).
To build and verify the container locally:
`docker build -t longest-increasing-subsequence .`

### GitHub Actions
This repository features a `.github/workflows/ci.yml` pipeline that triggers on `push` to `main`, automating verification of:
1. Linting
2. Build
3. Tests
4. Code coverage

## Deployment to GitHub
1. Make sure you are in the root directory.
2. Initialize and commit files:
   `git add .`
   `git commit -m "feat: complete solution setup"`
3. Create the public repository in GitHub with the generated UUID name: `9542a255-a249-43c1-bfa6-67de6b83f4f1`.
4. Link and push to GitHub:
   `git branch -M main`
   `git remote add origin https://github.com/YOUR_GITHUB_HANDLE/9542a255-a249-43c1-bfa6-67de6b83f4f1.git`
   `git push -u origin main`
