# 📦 Pharmacy App
# حاجة على ما قسم.
A Windows Forms-based pharmacy management system built using **.NET 6**, **Entity Framework Core (Code-First)**, and **SQL Server**. This project allows users to manage medicines, stock, categories, and provides a secure login and registration system.

---

## ✨ Features

- 🔐 User Authentication (Register & Login)
- 💊 Add, Edit, and Delete Medicines
- 📦 Manage Medicine Stock
- 🏷️ Categorize Medicines
- 💰 Display Medicine Prices, production date, and expiration date
- 🖥️ Simple and intuitive Windows Forms interface
- 📂 EF Core Migrations for automatic database setup

---

## 🧰 Tech Stack

- **Language:** C#
- **Framework:** .NET 6
- **Database:** SQL Server
- **ORM:** Entity Framework Core (Code-First with Migrations)
- **UI:** Windows Forms

---

## 🚀 Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/MrHelwa/Pharmacy_App.git
cd Pharmacy_App
```
## 2. Open in Visual Studio
Open the solution file .sln using Visual Studio 2022 or later.

Make sure you have the .NET 6 SDK and SQL Server installed.

## 3. Configure the Connection String
In your appsettings.json or directly in your PharmacyContext.cs, update the connection string to point to your SQL Server instance:
```
  "ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=PharmacyDB;Trusted_Connection=True;"
}
```
## 4. Apply EF Core Migrations
Open the terminal in the project root and run:
  dotnet ef database update
This command will create the database and all required tables using the included EF Core migrations.

## 5. Run the Application
Set Pharmacy_App as the startup project.

Press F5 or click Start in Visual Studio.
## 🗂️ Project Structure
```bash
Pharmacy_App/
│
├── Migrations/                      # EF Core migration files
│   ├── InitialMigration.cs
│   └── Snapshot.cs
│
├── Models/                          # Entity models
│   ├── Medicine.cs
│   ├── Category.cs
│   ├── User.cs
│   └── PharmacyContext.cs
│
├── Forms/
│   ├── Register_Page.cs             # Registration form
│   ├── LoginForm.cs                 # Login form
│   ├── MainForm.cs                  # Dashboard
│   ├── AddNewMedicineForm.cs       # Add/Edit medicine form
│   └── AddNewCategoryForm.cs       # Add/Edit category form
│
├── Program.cs                       # App entry point
└── README.md                        # Project documentation
```
## 📄 License
This project is licensed under the MIT License – free to use, modify, and distribute.
## 🙋‍♂️ Author
Abdulrahman Ibrahim Helwa
📧 abdohelwa123@gmail.com
