# To-Do List App

A professional **To-Do List web application** built using **ASP.NET Core MVC** and **Entity Framework Core**. This project allows users to **add, complete, undo, and delete tasks**, as well as **clear all completed tasks**. Each task also records its **creation timestamp**.

---

## Features

* Add new tasks with timestamp
* Mark tasks as **Complete** or **Undo**
* Delete individual tasks
* **Clear Completed Tasks** with a single click
* Tasks displayed in **newest-first order**
* Responsive design with **Bootstrap 5**
* Professional UI with cards, badges, and hover effects

---

## Technologies Used

* **ASP.NET Core MVC** (C#)
* **Entity Framework Core (EF Core)**
* **Bootstrap 5**
* **SQL Server LocalDB** (default database)

---

## Screenshots

*(Add screenshots of your app here if you want)*

---

## Getting Started

### Prerequisites

* [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
* Visual Studio 2022 or VS Code
* SQL Server LocalDB (comes with Visual Studio)

### Running the Project

1. Clone this repository:

```bash
git clone https://github.com/yourusername/TodoListApp.git
```

2. Navigate to the project folder:

```bash
cd TodoListApp
```

3. Restore dependencies:

```bash
dotnet restore
```

4. Run the application:

```bash
dotnet run
```

5. Open your browser and go to:

```
https://localhost:5001
```

---

## Project Structure

```
TodoListApp/
│-- Controllers/
│   └-- TodoItemsController.cs
│-- Models/
│   └-- TodoItem.cs
│-- Views/
│   ├-- TodoItems/
│   │   ├-- Index.cshtml
│   │   └-- _Create/Edit forms
│   └-- Shared/
│       ├-- _Layout.cshtml
│-- wwwroot/ (CSS, JS, images)
│-- Program.cs
│-- appsettings.json
```

---

## License

This project is **open source** and free to use for learning purposes.

---

