# Media Management System

This repository contains the implementation of a Media Management System, focusing on the management of books and movies. The project is structured around different layers: Models, Repositories, Services, MediatR Handlers, and Controllers. It also leverages **Feature Slices Architecture** and **Minimal API** for a clean, modular design that ensures scalability and maintainability.

## Table of Contents

- [Overview](#overview)
- [Project Structure](#project-structure)
  - [Models](#models)
  - [Repositories](#repositories)
  - [MediatR Handlers](#mediatr-handlers)
  - [Controllers](#controllers)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
  - [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)
- [Blog](#blog)

## Overview

This project demonstrates a clean architecture approach to managing books and movies using C#. It follows a modular design with separation of concerns, ensuring maintainability and scalability. The project leverages MediatR for handling requests, with distinct layers for data models, business logic, and HTTP handling. Additionally, it implements **Feature Slices Architecture** to group related functionality together and **Minimal API** to simplify the API layer.

## Project Structure

### Models

- **Books Model**: Represents the data structure for books
- **Movies Model**: Represents the data structure for movies

### Repositories

- **Books Repository**: Handles data access and persistence operations for books. This layer interacts with the database and performs CRUD operations.
- **Movies Repository**: Handles data access and persistence operations for movies. Similar to the Books Repository, it manages CRUD operations for movie data.

### MediatR Handlers

- **Book Commands/Queries Handler**: Handles MediatR requests related to books, such as adding a new book or querying book details.
- **Movie Commands/Queries Handler**: Handles MediatR requests related to movies, managing operations like adding a new movie or querying movie details.

### Controllers

- **Books Controller**: Manages HTTP requests and responses for books. It serves as the entry point for API calls related to book management.
- **Movies Controller**: Manages HTTP requests and responses for movies, handling API calls related to movie management.

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) installed on your machine.
- Basic knowledge of C# and ASP.NET Core.

### Installation

1. Clone the repository:

   ```bash
   git clone git@github.com:denisalibasic/FeatureSlices.git
   cd FeatureSlices
   ```
2. Restore the project dependencies:

    ```bash
   dotnet restore
   ```
3. Build the project:

   ```bash
   dotnet build
   ```

### Usage

1. Run the project:

   ```bash
   dotnet run
   ```
2. The API will be available locally. You can interact with the API using tools like Postman or Swagger

### Example API Endpoints

- Books
  - GET /api/books: Retrieve all books
  - POST /api/books: Add a new book
- Movies
  - GET /api/movies: Retrieve all movies
  - POST /api/movies: Add a new movie

### Contributing
Contributions are welcome! Please fork this repository, create a new branch, and submit a pull request

### License
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

### Blog
Link to related blog post:
== To be updated ==
