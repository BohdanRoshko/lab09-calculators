## Description
This repository contains various calculator applications developed as part of Lab 09. Each calculator serves a specific function, ranging from simple arithmetic to more complex calculations.

## Requirements
| Requirements                 |
|------------------------------|
| Visual Studio 2022 or older  |
| .Net 8                       |
| MySql Server Instance        |
| MySql Workbench              |

## Set Up
Download [Visual Studio](https://visualstudio.microsoft.com/downloads/) and install
In the installer select .Net 8 in individual components tab:
![image](https://github.com/BohdanRoshko/lab09-calculators/assets/107959377/13987a95-cb9e-4660-87df-2724237047ac)

Clone the repository to your local machine:
```bash
git clone https://github.com/BohdanRoshko/lab09-calculators.git
cd lab09-calculators
```
This project uses MySql database for storing statistcs of performed calculations.
To run the project you will require a [MySql Server](https://dev.mysql.com/downloads/installer/) instance running locally or remotely.

After installing MySql server instance, MySql Workbench and cloning the project edit appsettings.json file:
```json
"ConnectionStrings": {
    "DefaultConnection": "server=DESKTOP-2UM19UP;port=3306;database=mydatabase;user=root;password=password1234"
  }
```
Standard
```json
server=myServerAddress;port=myServerPort;database=myDataBase;user=myUsername;password=myPassword;
```
Next, run the following commands in PackageManager Console in Visual Studio to set up the database:
```bash
Add-Migration Initial
Update-Database
```
Upon successful completion, rebuild the solution in Visual Studio to restore all nuget packages and project is ready ro run

## Project Structure Diagram
![image](https://github.com/BohdanRoshko/lab09-calculators/assets/107959377/84992886-ead1-4f7e-bfeb-d7455a766ef3)
