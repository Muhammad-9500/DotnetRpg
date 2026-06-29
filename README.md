# 🎮 DotNet RPG API

A RESTful RPG (Role-Playing Game) backend built with **ASP.NET Core 7**, **Entity Framework Core**, and **SQL Server**. The API allows authenticated users to create and manage game characters, equip weapons, learn skills, and engage in battles.

This project was developed to demonstrate modern ASP.NET Core Web API development, authentication using JWT, Entity Framework Core, AutoMapper, and layered application architecture.

---

## ✨ Features

- User Registration & Login
- JWT Authentication & Authorization
- Character Management
  - Create characters
  - Retrieve character information
  - Update character details
  - Delete characters
- Weapon Management
  - Equip weapons to characters
- Skill Management
  - Learn and assign skills
- Battle System
  - Character vs Character combat
  - Weapon attacks
  - Skill attacks
  - High score tracking
- Swagger API Documentation

---

## 🛠 Technologies Used

- ASP.NET Core 7 Web API
- C#
- Entity Framework Core
- SQL Server
- JWT Authentication
- AutoMapper
- Swagger / OpenAPI

---

## 📁 Project Structure

```
Controllers/
Data/
Dtos/
Migrations/
Models/
Services/
Properties/
```

The project follows a layered architecture separating:

- Controllers
- Business Logic (Services)
- Data Access
- DTOs
- Database Models

---

## 🔐 Authentication

Authentication is implemented using JSON Web Tokens (JWT).

Users can:

- Register an account
- Login
- Receive a JWT token
- Access protected endpoints using Bearer Authentication

---

## ⚔ Main API Modules

### Authentication

- Register
- Login

### Characters

- Create Character
- Get Character
- Get All Characters
- Update Character
- Delete Character

### Weapons

- Add Weapon
- Equip Weapon

### Skills

- Learn Skill

### Fighting

- Character Attack
- Weapon Attack
- Skill Attack
- High Scores

---

## 🚀 Getting Started

### Prerequisites

- .NET 7 SDK
- SQL Server
- Visual Studio 2022 (Recommended)

### Clone the repository

```bash
git clone https://github.com/yourusername/DotnetRpg.git
```

### Configure the database

Update the connection string inside:

```
appsettings.json
```

Run Entity Framework migrations:

```bash
dotnet ef database update
```

### Run the project

```bash
dotnet run
```

or open the solution in Visual Studio and press **F5**.

Swagger will be available at:

```
https://localhost:<port>/swagger
```

---

## 📚 Learning Objectives

This project demonstrates practical experience with:

- RESTful API Design
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- Dependency Injection
- DTO Pattern
- AutoMapper
- Repository/Service Pattern
- JWT Authentication
- API Documentation using Swagger

---

## 📌 Future Improvements

- Docker Support
- Unit Testing
- Refresh Tokens
- Role-Based Authorization
- Logging
- Pagination & Filtering
- Inventory System
- Multiplayer Features

---

## 👨‍💻 Author

**Muhammad Saidu Abdullahi**

GitHub: https://github.com/Muhammad-9500
