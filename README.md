# 📦 Responsive Inventory Management System with RESTful Web Services

An enterprise-grade, multi-tier desktop application paired with a persistent REST API backend service, built as an Initial Project Report for **Systems Integration and Architecture 2 Laboratory (ITS152L-FOPM01)** at Mapúa University.

## 👥 Project Contributors
* **John Arion Galina**
* **Jay Angelo Labuguen**
* **Phia Vhianna Reign S. Ramirez**
* **Dariel Matthew Romulo**

**Submitted to:** Prof. Antonette D. Gabriel  
**Date:** June 26, 2026

---

## 🏛️ System Architecture Workflow
The platform utilizes a fully decoupled multi-tier architecture to separate user presentation mechanics from data management and service routing layers:

1. **Presentation Layer (Frontend Desktop Client - `InventoryApp`):**
   * Built on **C# Windows Forms (.NET 6.0)**.
   * Utilizes an asynchronous `HttpClient` pipeline to communicate with backend service routers using JSON format payloads.
   * Employs advanced `TableLayoutPanel` responsive layouts, enabling seamless screen resizing without UI breakdown.
2. **Service Layer (Backend Web API - `InventoryAPI`):**
   * Developed using **ASP.NET Core Web API (.NET 6.0)**.
   * Exposes structured REST endpoints mapped through an explicit API controller (`ItemsController.cs`).
3. **Data Persistence Layer (Database Server):**
   * Integrated via **Entity Framework Core (EF Core) 6.0** Object-Relational Mapper.
   * Connects to **Microsoft SQL Server (LocalDB)** to handle data persistence securely between software launches.

---

## 📊 Database Entity Model Properties (`Item.cs`)
The system tracks the following specific parameters mapped directly inside the database tables:
* `Id` (int, Primary Key) - Auto-incrementing unique system index key.
* `Name` (string) - Plain text description naming the product inventory asset.
* `Code` (string) - Unique Model number, barcode string, or product SKU.
* `Brand` (string) - Manufacturing brand identifier.
* `UnitPrice` (decimal) - Precise monetary cost value per unit asset.
* `StockQuantity` (int) - Live warehouse balance volume level.
* `LowStockThreshold` (int) - The safe stocking floor margin configured to trigger low stock warnings.

---

## 📡 RESTful Endpoints Protocol Map

| HTTP Method | API URL Route Path | Target System Execution Logic |
| :--- | :--- | :--- |
| **`GET`** | `/api/items` | Queries SQL database and fetches the active records list. |
| **`POST`** | `/api/items` | Sanitizes input data fields and commits a new item entry. |
| **`PUT`** | `/api/items/{id}` | Locates a specific record by ID and updates its values. |
| **`DELETE`** | `/api/items/{id}` | Erases the specified primary key record from the database. |

---

## ⚙️ Core Enhancements & System Logic (Beyond CRUD)
* 🛡️ **Defensive Input Safeguards:** Implements proactive front-end input filtering utilizing `int.TryParse` and `decimal.TryParse` variables to intercept letters or missing strings, preventing server crashes.
* ⚠️ **Low-Stock Alert Engine:** Calculates active inventory balances against set thresholds. Rows dropping below safe minimum margins automatically highlight in **Misty Rose** with dark red warnings on the grid interface.
* 💻 **Dynamic Form Autoscale:** Configured with specific `Anchor` parameters and flexible panel cells, guaranteeing a visually balanced UX from standard desktop states up to widescreen view formats.

---

## 🛠️ Step-by-Step Initial Setup Guide

### 1. Prerequisite Environments
* Microsoft Visual Studio 2022 containing the **.NET desktop development** workload module.
* LocalDB instance installed on your local computer.

### 2. Back-end Configuration & Migrations Execution
1. Open the solution in Visual Studio and choose `InventoryAPI` as your primary startup project.
2. Open the **Package Manager Console** (`Tools > NuGet Package Manager > Package Manager Console`).
3. Run the migrations update script to build the SQL Server local tables structure:
   ```powershell
   Update-Database
   ```
4. Press the green **Start/Play** button to load the API server. Your default browser will open to the Swagger API UI page (`http://localhost:5261/swagger/`). Keep this server running in the background.

### 3. Front-end Desktop Interface Booting
1. Open another instance of Visual Studio or change your configuration target settings to deploy **`InventoryApp`**.
2. Verify that the address base parameter `client.BaseAddress = new Uri("http://localhost:5261/");` matching inside the top constructor section of **`Form1.cs`** matches your actual active local port endpoint precisely.
3. Hit **Start** to run the fully functional desktop panel dashboard. Click the **Load** button to fetch records!
