FROM microsoft/dotnet:1.1.0-runtime-deps

WORKDIR /mynancyapi
COPY . .
EXPOSE 5000
ENTRYPOINT ["dotnet", "WebApi.dll"]
