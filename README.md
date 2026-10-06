# Pharmacy Management System (Console Application)

A lightweight and interactive **C# Console Application** designed to manage a pharmacy's drug inventory. This project demonstrates core **Object-Oriented Programming (OOP)** principles, safe user input validation, and dynamic collection handling in .NET.

## 🚀 Features
* **Add New Drugs:** Insert products with unique IDs, dynamic price formatting, and categorized types (e.g., Head, Heart, Stomach).
* **Duplicate Prevention:** Validates drug IDs before entry to prevent duplicate records.
* **Search Functionality:** Case-insensitive search to quickly locate medicines by name.
* **Remove Inventory:** Delete entries instantly from the system using their unique ID.
* **Categorized Filtering:** List and view products filtered strictly by their therapeutic category.
* **View Full Inventory:** Display a complete breakdown of all available medicines in the pharmacy.

## 🛠️ Technical Implementation
* **Language:** C# (.NET Core / .NET Standard)
* **Application Type:** Console Application CLI
* **Data Management:** Dynamic `List<T>` collection for CRUD-like operations in memory.
* **Input Validation:** Implementation of safe parsing (`int.TryParse`, `double.TryParse`) to prevent runtime crashes.
* **Encapsulation:** Proper modularity across `Program`, `Pharmacy`, and `Drug` classes.
