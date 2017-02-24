#!/bin/bash

for file in $(ls deploy_*.sh); do
    ./$file
done
