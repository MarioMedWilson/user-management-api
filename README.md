# User Management API

This is a simple API for user management built with .NET. It provides functionality to add new users and retrieve a list of all users.

## Prerequisites

- .NET SDK (6.0)
- A database (e.g., MySQL Server)
- Entity Framework Core

## Setup

#### 1. Clone the Repository
First, clone the repository to your local machine:
```bash
git clone https://github.com/MarioMedWilson/user-management-api
cd user-management-api
```

#### 2. Install Dependencies
Run the following command to restore all dependencies for the project:
```bash
dotnet restore
cd docker && docker-compose up
```

#### 3. Apply Migrations
To set up your database, apply the migrations. Run the following command:
``` bash
dotnet ef migrations add InitialMigration
```
```bash
dotnet ef database update
```
This will apply all pending migrations to your database.


#### 4. Run the API
Now, you can run the API using the following command:

```bash
dotnet run
```
The API will be available at http://localhost:5113.


### API Endpoints
#### 1. Create User (POST /api/users)
This endpoint allows you to create a new user.

Request Body:

```json
{
  "username": "user123",
  "firstname": "John",
  "lastname": "Doe",
  "password": "password123"
}
```
Response:
```json
{
  "message": "User created successfully",
  "userid": 1
}
```

#### 2. Get All Users (GET /api/users)
This endpoint allows you to retrieve a list of all users.

Response:
```json
[
  {
    "userid": 1,
    "username": "user123",
    "firstname": "John",
    "lastname": "Doe"
  }
]
```
