Download The Following Requirements

1. MySQL for C#/ Database setup

Download the sql file (event_information_system.sql)

Options
The system uses MySQL as a database
choose an option below

Option A

XAMPP (Best for beginners)

- Open Control Panel
- Start Apache and MySQL
- Go to http://localhost/phpmyadmin

create a database named event_information_system
import your .sql file, then click go.


Option B 

MySQL WorkBench(best for professionals)

Install the following requirments
- MySQL Server
- MySQL Workbench

DOwnload
- MySql Community Server
- MySQL WorkBench

Setup
1. Install  MySql Community Server and workbench
2. open MySQL workbench
3. Create a connection via local host
4. Open Server -> Data Import
5. Select event_information_system.sql file
6. Click Start Import

C# Connection to MySQL database

server=localhost;database=event_information_system;iud=root;pwd;



2. Visual Studio Requirements

Make sure that you have
- Visual Studio 2019/2022
- .NET Framework (.NET Desktop Development) 
  - Open Visual Studio Installer -> click modify -> go to Desktop % Mobile
then install .NET Desktop Development
- Windows Form App (.NET Framework)

Excel Library

Download EPPPlus on
Tools -> Package Manager Console
then place "Install-Package EPPPlus" on Powershell or cmd in C# to install

Download the Following NuGet Packages
- MySQL.Data
- EPPlus

How to run
1. Open the project in Visual Studio/Visual Studio Insiders
2. Restore NuGet Packages
3. Run the application  (start Debugging)
