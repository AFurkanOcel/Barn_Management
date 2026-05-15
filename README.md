<h1 align="center">Barn Management System</h1>

<p align="center">
Desktop-based barn/farm management application built with C#, WinForms and Entity Framework.
</p>

<p align="center">
  <img src="https://img.shields.io/badge/.NET%20Framework-4.8-purple"/>
  <img src="https://img.shields.io/badge/UI-Windows%20Forms-blue"/>
  <img src="https://img.shields.io/badge/ORM-Entity%20Framework%206-green"/>
  <img src="https://img.shields.io/badge/Database-SQL%20Server-red"/>
  <img src="https://img.shields.io/badge/Architecture-Layered-orange"/>
  <img src="https://img.shields.io/badge/Status-Completed-brightgreen"/>
</p>

---

## Project Overview

Managing livestock and barn operations manually can become inefficient and error-prone as data grows.

This project solves that problem by providing a structured desktop application that enables:

* Animal registration and monitoring
* Product and inventory management
* Transaction recording
* Secure user authentication
* Centralized data management

<img width="920" height="598" alt="Menu" src="https://github.com/user-attachments/assets/2d42e8ad-19e5-4603-b0a0-eb01e76b727c" />

---

## Project Structure

```text
Barn_Management/
│── Barn_Management.sln
│── README.md
│
├── PresentationLayer/
│   ├── MainForm.cs
│   ├── Pages/
│   │   ├── LogInForm.cs
│   │   ├── SignUpForm.cs
│   │   ├── AnimalForm.cs
│   │   ├── ProductsForm.cs
│   │   ├── SalesForm.cs
│   │   └── SettingsForm.cs
│   ├── App.config
│   └── Audios/
│       └── Music.mp3
│
├── BusinessLayer/
│   └── Business logic services
│
├── DataAccessLayer/
│   ├── Abstract/
│   ├── Migrations/
│   └── Entity Framework repositories
│
├── EntityLayer/
│   └── Entities/
│       ├── User.cs
│       ├── Animal.cs
│       ├── Product.cs
│       └── Transaction.cs
│
└── ProjectUtils/
    └── Shared helper utilities
```

---

## Features

### Authentication & Security

* User registration
* User login
* Password hashing using **BCrypt**
* Global authentication/session handling

### Animal Management

* Add new animals
* Update animal records
* Delete animals
* View all registered animals

### Product Management

* Add, edit and remove products
* Product stock tracking
* Inventory organization

### Sales & Transactions

* Record sales transactions
* Track product movements
* Transaction history support

### Settings

* User and application settings management

### Logging

* File-based logging with **Serilog**
* Error and event tracking

### Extra Feature

* Background music support using **Windows Media Player API**

---

## Technologies Used

| Category             | Technology                               |
| -------------------- | ---------------------------------------- |
| Language             | C#                                       |
| Framework            | .NET Framework 4.8                       |
| UI                   | Windows Forms                            |
| ORM                  | Entity Framework 6.5.1                   |
| Database             | Microsoft SQL Server                     |
| Security             | BCrypt.Net                               |
| Logging              | Serilog                                  |
| Dependency Injection | Microsoft.Extensions.DependencyInjection |
| Architecture         | Layered Architecture                     |

---

## Architecture

This project follows a **5-layer architecture**:

```mermaid
graph TD
    A[Presentation Layer] --> B[Business Layer]
    B --> C[Data Access Layer]
    C --> D[Entity Layer]
    E[ProjectUtils] --> A
    E --> B
    E --> C
```

---

## Layer Responsibilities

### PresentationLayer

Contains all Windows Forms UI pages.

Forms:

* LoginForm
* SignUpForm
* AnimalForm
* ProductsForm
* SalesForm
* SettingsForm
* MainForm

### BusinessLayer

Contains business rules and service logic.

### DataAccessLayer

Responsible for database communication.

Includes:

* Repository operations
* Entity Framework context
* Code First Migrations

### EntityLayer

Contains entity models:

* Animal
* Product
* Transaction
* User

### ProjectUtils

Shared helper and utility classes.

---

## Database

Database provider:

`Microsoft SQL Server`

Connection string example:

```xml
Data Source=YOUR_SERVER_NAME;
Initial Catalog=BarnManagement;
Integrated Security=True
```

Uses:

* Entity Framework Code First
* Migration Configuration

---

## Installation

### 1. Clone repository

```bash
git clone https://github.com/AFurkanOcel/Barn_Management.git
```

### 2. Open solution

Open:

`Barn_Management.sln`

using **Visual Studio**.

### 3. Restore NuGet packages

```powershell
Update-Package -reinstall
```

or

```powershell
nuget restore
```

### 4. Configure database

Open:

`PresentationLayer/App.config`

and update the connection string with your SQL Server instance.

### 5. Apply migrations

Open Package Manager Console:

```powershell
Update-Database
```

### 6. Run

Set **PresentationLayer** as startup project and run.

---

## Screenshots

### Login - Signup

<img width="909" height="595" alt="LogIn_SignUp" src="https://github.com/user-attachments/assets/46c7067d-ed1d-4344-a57f-b1212d714878" />

### Animals

<img width="919" height="597" alt="Animals" src="https://github.com/user-attachments/assets/d7754e9c-1a0f-49d8-a060-d5601d802cb4" />

### Products

<img width="920" height="599" alt="Products" src="https://github.com/user-attachments/assets/d7fc6b76-7b2a-4dc6-a829-2d6efe929ee8" />

### Sales

<img width="918" height="598" alt="Sales" src="https://github.com/user-attachments/assets/69f57d2d-a7fa-48e1-a15f-8843871dc536" />

### Settings

<img width="920" height="597" alt="Settings" src="https://github.com/user-attachments/assets/f5945d85-e286-4bbe-8a9b-b38a8f3fde83" />

---

## Future Improvements

* Role-based authorization
* Reporting dashboard
* Barcode support
* Cloud synchronization
* Backup and restore support
* Modern UI redesign (WPF / MAUI)

---

## Learning Outcomes

This project helped improve my experience in:

* Layered architecture design
* Entity Framework
* Relational database design
* Desktop application development
* Authentication systems
* Logging systems
* Software architecture principles

---

## Author

**A. Furkan ÖCEL**
