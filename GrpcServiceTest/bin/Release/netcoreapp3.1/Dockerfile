FROM mcr.microsoft.com/dotnet/core/aspnet:3.0 AS base
WORKDIR /app
EXPOSE 5000

COPY . /app
ENTRYPOINT ["dotnet", "GrpcServiceTest.dll"]
