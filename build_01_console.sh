#!/bin/bash

cd ./src/Console
dotnet restore
dotnet build --configuration Release
