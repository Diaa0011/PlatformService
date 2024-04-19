# Intro
The idea behind the project that we have a a website which contain some platforms.
Each Platform has some commands which give us some functionalties for each platform 
as example: for docker we have "docker push imageName" which push image on dockerhub

---------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------
# Project Overview
The project aims to develop a website housing multiple platforms, each offering specific functionalities through commands. For instance, Docker commands like "docker push <imageName>" enable project deployment.

# Architecture
The project consists of four main components:

  - Platform Service File: This file manages the various platforms available on the website.
  - Commands Service File: Here, commands corresponding to each platform are handled.
  - Kubernetes Management File (K8S): This file is responsible for managing Kubernetes, particularly for orchestrating images.

Illustration of the architecture of the project
![photo_2024-04-19_02-39-58](https://github.com/Diaa0011/PlatformService/assets/98353830/07e40885-f77a-4235-be1c-fe65af2a600d)

Communication between the services is illustrated as follows:
![photo_2024-04-19_02-42-49](https://github.com/Diaa0011/PlatformService/assets/98353830/82bbcc70-cb71-40de-bcc1-3d66d1d9d3cf)

# Technologies Used
- **.NET:** Used for development.
- **SQL Server:** Database management system.
- **Docker:** Deployment of the application.
- **Kubernetes:** Orchestrating images.
- **RabbitMQ:** For communication and load balancing.
- **gRPC:** Facilitating communication between services.

---------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------
# How to run ?
- Installing images 
  - platformService: 
  - commandservice:


