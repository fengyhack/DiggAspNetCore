# TheaterWeb #

[TOC]

## Intro ## 

ASP .NET Core Web App (.NET Core 3.1) with PostgreSQL 10 Database

*Visual Studio 2019* (version 16.4.4 or higher) on Windows 10



## Step-by-Step ##

### 0.PostgreSQL Database ###

**Create a database named `Ocean` using `pgAdmin` or other tools**

![00](imgs/00.png) 



### 1. Create a New ASP .NET Core Web Application ###

**Select `.NET Core` `ASP.NET Core 3.1`**

![01](imgs/01.png)



### 2. Prepare Data Models ###



**2.1. Install Packages (`EF Core` and `Npgsql`)**



Install these packages one by one in `PM>`

```
Install-Package Npgsql.EntityFrameworkCore.PostgreSQL

Install-Package Npgsql.EntityFrameworkCore.PostgreSQL.Design

Install-Package Microsoft.EntityFrameworkCore.Tools
```



**2.2. Scaffold DB Context**



Firstly, create the output folder (*Models*), then type the script below in `PM>`

```
Scaffold-DbContext “Server=localhost;Database=Ocean;User ID=postgres;Password=postgres;” Npgsql.EntityFrameworkCore.PostgreSQL -OutputDir Models
```



![03](imgs/03.png)



### 3. Connection Settings ###



**3.1. Remove the override method `DbContext.OnConfiguring`**

![04](imgs/04.png)



**3.2. Edit App Settings**



`appsettings.json` *ConnectionStrings* and `Startup.ConfigureServices`



![05](imgs/05.png)

![06](imgs/06.png)



### 4. Add New Razor Page ###

**4.1. Right click on the `Pages` folder, `Add` --> `Razor Page`**

![07](imgs/07.png)



**4.2. Select `Using Entity Framework to Generate Razor Page (CRUD)`**

![08](imgs/08.png)



**4.3. Select `Model` and `Data Context` as below**

![09](imgs/09.png)



**4.4. Then click `Add`, required packages can be automatically installed. **



### 5. Run in a browser (maybe Chrome) ###



Screenshot like this:

![10](imgs/10.png)
