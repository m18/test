#!/bin/bash

echo "Copying (recursively -r) the build artifacts to the host..."
scp -r ./src/WebApi/bin/Release/netcoreapp1.0/publish m@10.0.2.15:./Desktop/build_output

imageName="mynancyapi"
containerName="myapicontainer"

# single-line command
# ssh m@10.0.2.15 "cd Desktop/build_output/Release/netcoreapp1.0"

# multi-line commands
# ssh w/out allocating a pseudo-terminal -T
ssh -T m@10.0.2.15 << EOF
	echo "Running on the host now"
	cd ./Desktop/build_output

	echo "Checking if container is running..."
	if [ "\$(docker ps -qf name=^/$containerName$)" != "" ]; then
		echo "Container is running, stopping..."
		docker stop $containerName
	fi

	echo "Checking if image already exists..."
	echo "(optional, can be omitted as images are overwritten by new ones)"
	if [ "\$(docker images -q $imageName)" != "" ]; then
		echo "Image exists, removing..."
		docker rmi $imageName
	fi
	
	echo "Building a Docker image..."
	docker build -t $imageName .
        
	echo "Starting a container..."
	docker run -itdp 5001:5000 -e "ASPNETCORE_URLS=http://+:5000" --rm --name $containerName $imageName
EOF
