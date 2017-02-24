#!/bin/bash

for file in $(ls build_*.sh); do
    ./$file
done
