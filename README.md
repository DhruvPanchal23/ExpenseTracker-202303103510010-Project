# Expense Tracker

## Description

This project is a simple expense tracking application. It features a backend API built with .NET 9 and ASP.NET Core, which handles the business logic and data storage. The API uses Entity Framework Core with a **SQLite** database (`expenses.db`) to store expense records.

The API provides endpoints for:
* **GET** `/api/expenses`:Retrieves a list of all expenses.
* **POST** `/api/expenses`: Adds a new expense to the database.
* **DELETE** `/api/expenses/{id}`: Deletes a specific expense by its ID.

A basic **HTML and JavaScript frontend** is included, allowing users to add new expenses (title, amount, category) and view a list of all current expenses. The frontend communicates with the backend API running on `http://localhost:5000`.

The project also includes **Swagger** for API documentation and testing, which is available when the project is run in a development environment.

---

## Installation

1.  **Clone the repository** (or ensure you have all the project files).
2.  **Install .NET 9 SDK** (if not already installed).
3.  Open a terminal or command prompt and navigate to the project's root directory (where `ExpenseTrackerAPI.csproj` is located).
4.  Run the following command to restore the necessary NuGet packages:
    ```bash
    dotnet restore
    ```

---

## How to Run the Project

The project consists of a backend API and a frontend HTML file. Both must be running to use the application.

### 1. Run the Backend (API)

1.  In your terminal, navigate to the project's root directory (e.g., `.../ExpenseTracker-202303103510010-Project-0adc6a2aa09d32b8f22e069f706c32b32c82a1ce/`).
2.  Run the project using the following command:
    ```bash
    dotnet run
    ```
3.  The API server will start. By default, it will listen on `http://localhost:5000` (as referenced in the frontend code).
4.  You can optionally open `http://localhost:5000/swagger` in your browser to view and test the API endpoints directly.

### 2. Run the Frontend

1.  Navigate to the `frontend` sub-directory.
2.  Open the **`index.html`** file directly in any modern web browser (e.g., Chrome, Firefox, Edge).
3.  The webpage will load, and you can now add and view expenses. The form will send requests to the backend API you started in the previous step.
