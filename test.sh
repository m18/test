#!/bin/bash

for file in $(ls test_*.sh); do
    ./$file
done
