FROM ubuntu:20.04

ENV DEBIAN_FRONTEND=noninteractive
RUN apt-get update
RUN apt-get -y install tzdata
RUN ln -fs /usr/share/zoneinfo/Europe/Rome /etc/localtime 
RUN dpkg-reconfigure --frontend noninteractive tzdata 

RUN apt install -y wget vim
RUN wget https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb && dpkg -i packages-microsoft-prod.deb
 
RUN apt update
RUN apt install -y apt-transport-https dotnet-sdk-5.0 aspnetcore-runtime-5.0

ENV ASPNETCORE_URLS=http://*:5006
ENV ASPNETCORE_ENVIRONMENT="production"

EXPOSE 5006
WORKDIR /app
ENTRYPOINT ["dotnet", "App.dll"]