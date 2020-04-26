This **Rest API Backend** is for the Mitrais coding test purpose.

#Note
- The technology using .NET Core
- The database engine using SQL Server

#How to Run
- Create database on your environment

**Visual Studio**

- Open Project With Visual Studio
- Open *appsettings.json* and update the ConnectionStrings section based on your environment 
- run Update-Database in *Powershell or Package Manager* -> (Migration database)
- run Visual Studio debugging, will start in http://localhost:5566

**Visual Code**

- Open Project with Visual Code
- Open *appsettings.json* and update the ConnectionStrings section based on your environment
- run dotnet ef database update (.Net Core CLI / Visual Code Terminal / Cmd P) -> (Migration database)
- run dotnet run, will start in http://localhost:5566