
# Ticket Management API 🎫

Welcome to the **Ticket Management API**! This service allows you to manage tickets in an efficient and easy way. You can create, read, update, and delete tickets through this RESTful API built with **ASP.NET Core**.

## How It Works 🛠️

The API provides several endpoints for interacting with tickets. These are the main ones:

### 1. **Get All Tickets** 📜

- **Endpoint:** `GET /api/tickets`
- **Description:** Retrieves a list of all tickets.
- **Example Response:**
  ```json
  [
    {
      "id": 1,
      "title": "Ticket 1",
      "description": "Description of ticket 1",
      "status": "Open"
    },
    {
      "id": 2,
      "title": "Ticket 2",
      "description": "Description of ticket 2",
      "status": "Closed"
    }
  ]
  ```

### 2. **Get Ticket by ID** 🔍

- **Endpoint:** `GET /api/tickets/{id}`
- **Description:** Retrieves details of a specific ticket by its ID.
- **Example Response:**
  ```json
  {
    "id": 1,
    "title": "Ticket 1",
    "description": "Description of ticket 1",
    "status": "Open"
  }
  ```

### 3. **Create a New Ticket** ✍️

- **Endpoint:** `POST /api/tickets`
- **Description:** Creates a new ticket.
- **Required Data:** Title, description, and status of the ticket.
- **Example Request:**
  ```json
  {
    "title": "New Ticket",
    "description": "Description of the new ticket",
    "status": "Open"
  }
  ```

- **Example Response:**
  ```json
  {
    "id": 3,
    "title": "New Ticket",
    "description": "Description of the new ticket",
    "status": "Open"
  }
  ```

### 4. **Update Ticket** ✨

- **Endpoint:** `PUT /api/tickets/{id}`
- **Description:** Updates an existing ticket.
- **Example Request:**
  ```json
  {
    "title": "Updated Ticket",
    "description": "Updated description",
    "status": "Closed"
  }
  ```

- **Example Response:**
  ```json
  {
    "id": 1,
    "title": "Updated Ticket",
    "description": "Updated description",
    "status": "Closed"
  }
  ```

### 5. **Delete Ticket** ❌

- **Endpoint:** `DELETE /api/tickets/{id}`
- **Description:** Deletes a ticket from the system.

---

## How to Use the API 📝

### 1. **Run the Application**
   - Ensure you have **.NET Core** installed on your machine.
   - Run the project in Visual Studio or via the terminal using `dotnet run`.

### 2. **Access the Swagger UI**
   - Once the application is running, you can interact with all available endpoints using **Swagger UI**.
   - Open your browser and go to: `http://localhost:{port}/swagger`

### 3. **Test the Endpoints**
   - In Swagger UI, you can see all available endpoints.
   - Click on an endpoint (for example, `GET /api/tickets`), click **"Try it out"**, and press **"Execute"** to see the response.

---

## Key Features 🚀

- **Manage Tickets**: Create, read, update, and delete tickets through simple API endpoints.
- **Swagger UI**: Easily test and interact with the API using an interactive interface.
- **Simple Integration**: The API is built using **ASP.NET Core** for quick setup and integration.

---

## Technologies Used 🔧

- **ASP.NET Core**: The framework for building the web API.
- **Entity Framework Core**: ORM for database interaction.
- **SQL Server**: Database to store the ticket information.
- **Swagger**: Documentation tool for API testing and interaction.

---
