#!/bin/bash

for file in $(ls publish_*.sh); do
    ./$file
done
