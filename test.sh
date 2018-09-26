#!/bin/bash 

sudo
cd Mobile/Fennec
npm install
npm i native-script
tns test android
tns test ios
return 5