````md
# Barn Management System

![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.8-purple)
![WinForms](https://img.shields.io/badge/UI-Windows%20Forms-blue)
![Entity Framework](https://img.shields.io/badge/ORM-Entity%20Framework%206-green)
![SQL Server](https://img.shields.io/badge/Database-SQL%20Server-red)
![Architecture](https://img.shields.io/badge/Architecture-Layered-orange)
![Status](https://img.shields.io/badge/Status-Completed-brightgreen)

A desktop-based **Barn Management System** developed with **C#**, **Windows Forms**, and **Entity Framework 6**, following a **Layered Architecture** approach.

This application was designed to digitalize and simplify farm/barn operations such as **animal tracking**, **product inventory management**, **sales transactions**, and **user authentication** through a clean desktop interface.

---

# Project Overview

Managing livestock and barn operations manually can become inefficient and error-prone as data grows.

This project solves that problem by providing a structured desktop application that enables:

- animal registration and monitoring,
- product/inventory management,
- transaction recording,
- secure user authentication,
- and centralized data management.

---

# Features

### Authentication & Security
- User registration
- User login
- Password hashing using **BCrypt**
- Global authentication/session handling

---

### Animal Management
- Add new animals
- Update animal records
- Delete animals
- View all registered animals

---

### Product Management
- Add/edit/remove products
- Product stock tracking
- Inventory organization

---

### Sales & Transactions
- Record sales transactions
- Track product movements
- Transaction history support

---

### Settings
- User/application settings management

---

### Logging
- File-based logging with **Serilog**
- Error/event tracking

---

### Extra Feature
- Background music support using **Windows Media Player API**

---

# Technologies Used

| Category | Technology |
|----------|------------|
| Language | C# |
| Framework | .NET Framework 4.8 |
| UI | Windows Forms |
| ORM | Entity Framework 6.5.1 |
| Database | Microsoft SQL Server |
| Security | BCrypt.Net |
| Logging | Serilog |
| Dependency Injection | Microsoft.Extensions.DependencyInjection |
| Architecture | Layered Architecture |

---

# Architecture

This project follows a **5-layer architecture**:

```text
Presentation Layer
    ↓
Business Layer
    ↓
Data Access Layer
    ↓
Entity Layer

+ ProjectUtils (shared utilities)
````

### Layer Responsibilities

#### PresentationLayer

Contains all Windows Forms UI pages.

Forms:

* LoginForm
* SignUpForm
* AnimalForm
* ProductsForm
* SalesForm
* SettingsForm
* MainForm

---

#### BusinessLayer

Contains business rules and service logic.

---

#### DataAccessLayer

Responsible for database communication.

Includes:

* Repository operations
* Entity Framework context
* Code First Migrations

---

#### EntityLayer

Contains entity models:

* Animal
* Product
* Transaction
* User

---

#### ProjectUtils

Shared helper/utility classes.

---

# Database

Database provider:

```text
Microsoft SQL Server
```

Connection string (example):

```xml
Data Source=YOUR_SERVER_NAME;
Initial Catalog=BarnManagement;
Integrated Security=True
```

Uses:

* Entity Framework Code First
* Migration Configuration

---

# Installation

## 1. Clone repository

```bash
git clone https://github.com/YOUR_USERNAME/Barn_Management.git
```

---

## 2. Open solution

Open:

```text
Barn_Management.sln
```

using **Visual Studio**.

---

## 3. Restore NuGet packages

```powershell
Update-Package -reinstall
```

or:

```powershell
nuget restore
```

---

## 4. Configure database

Open:

```text
PresentationLayer/App.config
```

update:

```xml
<connectionStrings>
```

with your SQL Server instance.

---

## 5. Apply migrations

Open Package Manager Console:

```powershell
Update-Database
```

---

## 6. Run

Set:

```text
PresentationLayer
```

as startup project and run.

---

# Screenshots

## Login Screen

`[Add Login screenshot here]`

---

## Dashboard / Main Form

`[Add MainForm screenshot here]`

---

## Animal Management

`[Add AnimalForm screenshot here]`

---

## Product Management

`[Add ProductsForm screenshot here]`

---

## Sales Page

`[Add SalesForm screenshot here]`

---

## Settings

`[Add SettingsForm screenshot here]`

---

# Future Improvements

* role-based authorization
* reporting dashboard
* barcode support
* cloud synchronization
* backup/restore support
* modern UI redesign (WPF / MAUI)

---

# Learning Outcomes

This project helped improve my experience in:

* layered architecture design
* Entity Framework
* relational database design
* desktop application development
* authentication systems
* logging systems
* software architecture principles

---

# Author

**Ahmet Furkan Öcel**
Computer Engineering Student
Bursa Technical University

GitHub: https://github.com/AFurkanOcel

```
```
