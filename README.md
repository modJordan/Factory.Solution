# Dr. Sillystringz's Factory Management Application

#### By **Jordan**

A web application built for the renowned Dr. Sillystringz's Factory to manage engineers and machines they're licensed to repair.

## Technologies Used

- .NET 5.0
- ASP.NET Core MVC
- Entity Framework Core
- Bootstrap
- C#
- HTML
- CSS

## Description

Dr. Sillystringz's Factory Management Application enables the factory manager to oversee engineers and the machines they are licensed to repair. This platform offers functionalities to add engineers, machines, associate engineers with specific machines they can repair, and vice versa.

## Setup/Installation Requirements

- Ensure .NET SDK and runtime are installed on your machine.
- Clone this repository to your local machine.
- Navigate to the Factory.Solution directory in your terminal.

<details>
<summary>Recreate the database using the jordan_kennedy.sql file:</summary>

1. Open your preferred SQL platform (e.g., MySQL Workbench, SQL Server Management Studio).
2. Create a new database named factorydb.
3. Import the jordan_kennedy.sql file into this database to set up the tables and initial data.
4. Create an appsettings.json file in the Factory.Solution/Factory directory with the following content (adjust the connection string as needed based on your SQL setup):

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=factorydb;uid=YOUR_USERNAME;pwd=YOUR_PASSWORD;"
  }
}
```
Replace YOUR_USERNAME and YOUR_PASSWORD with your SQL server's username and password.

</details>
<br>

- Run the command dotnet restore to install necessary packages.
- Run the command dotnet build to compile the application.
- Run dotnet run to start the server and application.
- Visit localhost:5000 in your browser to access the Dr. Sillystringz's Factory Management Application.
- Follow on-screen prompts to manage engineers and their associated machines.

## User Stories

- As the factory manager, I can see a list of all engineers and machines.
- I can select an engineer, view their details, and see all the machines they are licensed to repair.
- Similarly, I can select a machine, view its details, and see all engineers licensed to repair it.
- I can add new engineers or machines to the system.
- I can associate specific machines with an engineer and vice versa.
- The system ensures that I don't add empty or invalid details.

## Known Bugs

No known bugs at the moment.
Feedback and bug reports are always welcome.

## License

Feel free to reach out if you have any concerns, feedback, or wish to make contributions to the code.

Copyright (c) 2023 [Jordan]