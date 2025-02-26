# BandidGirlsAPI

This project is an API developed in **ASP.NET Core 8** using **Entity Framework** for data management. It provides endpoints to interact with the `BandidGirls` entity and perform CRUD operations.

## Technologies Used

- ASP.NET Core 8
- Entity Framework Core
- SQL Server** (or whatever database you have used)

## Project Structure

- Controllers**: Contains the API controllers.
- Models**: Defines the entities and data models.
- Data**: Includes the database context and Entity Framework configurations.
- Migrations**: Contains the migrations generated for the database.

## Endpoints

The following are the endpoints available in the API:

### GET /api/BandidGirls
- Description**: Gets a list of all `BandidGirls`.
- Response**: List of `BandidGirl` objects.

### GET /api/BandidGirls/{id}
- Description**: Gets a specific `BandidGirl` by its ID.
- Response**: `BandidGirl` object.

### POST /api/BandidGirls
- Description**: Creates a new `BandidGirl`.
- Body**: `BandidGirl` object in JSON format.
- Response**: `BandidGirl` object created.

### PUT /api/BandidGirls/{id}
- Description**: Update an existing `BandidGirl` by its ID.
- Body**: `BandidGirl` object in JSON format.
- Response**: Updated `BandidGirl` object.

### DELETE /api/BandidGirls/{id}
- Description**: Deletes a `BandidGirl` by its ID.
- Response**: Status code 204 (No Content).

## Referencias

- Create a web API with ASP.NET Core(https://docs.microsoft.com/en-us/aspnet/core/?view=aspnetcore-8.0](https://learn.microsoft.com/es-es/aspnet/core/tutorials/first-web-api?view=aspnetcore-9.0&tabs=visual-studio)
- Publish to Azure API Management using Visual Studio: (https://docs.microsoft.com/en-us/ef/core/](https://learn.microsoft.com/es-es/aspnet/core/tutorials/publish-to-azure-api-management-using-vs?view=aspnetcore-9.0)
- Modeling with Entity Framework Core: https://docs.microsoft.com/en-us/ef/core/](https://learn.microsoft.com/es-es/aspnet/core/tutorials/publish-to-azure-api-management-using-vs?view=aspnetcore-9.0](https://learn.microsoft.com/en-us/ef/core/modeling/)
- Managing migrations in Entity Framework Core: https://learn.microsoft.com/en-us/ef/core/managing-schemas/migrations/managing?tabs=dotnet-core-cli)(https://docs.microsoft.com/en-us/ef/core/](https://learn.microsoft.com/en-us/ef/core/managing-schemas/migrations/managing?tabs=dotnet-core-cli)

## How to Run the Project

Clone the repository.

Configure the connection string in appsettings.json.

Apply migrations to create the database using Visual Studio:

Open Package Manager Console in Visual Studio.

Run the following command:Update-Database

