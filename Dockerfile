FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base

WORKDIR /app

COPY ./publish .

ENTRYPOINT ["dotnet", "NET_Core_Introduction.dll"]