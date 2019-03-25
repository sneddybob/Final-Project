# Finalizer or: How I Learned to Stop Worrying and Love the Code

## Project Overview

This is Bob Snediker's final project for Coding Temple's Feb 2019 .NET bootcamp.  As of 3/25/19 it uses ASP.NET, 
SQL edited via the Microsoft SMS and Bootstrap dependecy for CSS/HTML formatting.  It is meant to demonstrate some of the core
elements of a full stack web application.

![image](/Finalizer/wwwroot/images/es355redSM.png)

## Getting Started
- Clone the application from GitHub.
- Download and Install Visual Studio Community and Configure for the DotNetCore Development workspace.
- Make sure to download the .NET Core 2.1 SDK or runtime libraries
- Double Click the .sln file to open the project
- Initialize the connection string path from the CMD line (see below : Connection String Initialization)
- Hit "Play" to run

### Connection String Initialization

The ABCReport controller is configured to communicate with a database with the ABC Manufacturing Database Schema.  The connection string must be set prior to using the report.  From the command line:

`dotnet user-secrets set "ConnectionStrings:ABCConnection" "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ABCMFGDB2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"`
