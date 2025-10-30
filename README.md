# Expense Tracker

## Description

This project is a simple, full-stack expense tracking application. It consists of a .NET Web API backend and a simple HTML/JavaScript frontend.

The backend is built with **.NET 9** and **ASP.NET Core**, providing a RESTful API for managing expense records. It uses **Entity Framework Core 9** to interact with a **SQLite** database, making it lightweight and self-contained. The API is documented using **Swagger (Swashbuckle)**, which is available in the development environment.

The frontend is a single `index.html` file that uses vanilla **JavaScript** and the `fetch` API to communicate with the backend. It allows users to add new expenses (title, amount, category) and view a list of all current expenses.

---

## Tech Stack

### Backend
* **.NET 9**
* **ASP.NET Core Web API**
* **Entity Framework Core 9**
* **SQLite** (for data storage)
* **Swashbuckle (Swagger)** (for API documentation)

### Frontend
* **HTML5**
* **Vanilla JavaScript** (ES6+ async/await)

---

## Project Details

### API Endpoints
The backend API is managed by the `ExpensesController` and provides the following endpoints:

* `[HttpGet] /api/expenses`
    * **Description:** Retrieves a list of all expenses from the database.
    * **Response:** `200 OK` with a JSON array of expense objects.
   

* `[HttpPost] /api/expenses`
    * **Description:** Adds a new expense to the database.
    * **Request Body:** A JSON object representing the expense (e.g., `{"title": "Coffee", "amount": 5.00, "category": "Food"}`).
    * **Response:** `200 OK` with the newly created expense object.
   

* `[HttpDelete] /api/expenses/{id}`
    * **Description:** Deletes a specific expense by its unique ID.
    * **Response:** `204 NoContent` if successful, or `404 NotFound` if the expense with the given ID does not exist.
   

### Frontend Functionality
The `frontend/index.html` file provides the user interface:

* **View Expenses:** On page load, an `async` function `loadExpenses()` is called, which fetches all expenses from the `GET /api/expenses` endpoint and displays them in an unordered list.
* **Add Expense:** A form (`#expenseForm`) captures the title, amount, and category for a new expense. On submission, it sends this data to the `POST /api/expenses` endpoint using a `fetch` request.
* **Auto-Refresh:** After a new expense is successfully submitted, the `loadExpenses()` function is called again to refresh the list, and the form is reset.

---

## Installation

1.  **Clone the repository** (or ensure you have all the project files).
2.  **Install .NET 9 SDK** (if not already installed).
3.  Open a terminal or command prompt and navigate to the project's root directory (where `ExpenseTrackerAPI.csproj` is located).
4.  Run the following command to restore the necessary NuGet packages:
    ```bash
    dotnet restore
    ```
5.  The project is configured to use Entity Framework Core. The database (`expenses.db`) will be created automatically in the root folder when the application is first run, based on the `AppDbContext` configuration.

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

<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/fe7670af-72e2-490e-b353-ffbdc00a5eec" />

