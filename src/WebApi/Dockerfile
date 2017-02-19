FROM microsoft/dotnet:1.1.0-sdk-msbuild-rc4

WORKDIR /mynancyapi
COPY . .
EXPOSE 5000
ENTRYPOINT ["dotnet", "WebApi.dll"]
