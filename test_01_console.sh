#!/bin/bash

cd ./test/Console.Tests
dotnet restore
dotnet test --configuration Release
