#!/bin/bash

cd ./src/WebApi
dotnet restore
dotnet publish --configuration Release
