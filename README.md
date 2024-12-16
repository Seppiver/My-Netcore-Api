# My .NET Core API

This project is a simple .NET Core API for managing a collection of books. It provides a RESTful interface for performing CRUD operations on book entities.

## Project Structure

- **Controllers**
  - `BooksController.cs`: Handles HTTP requests related to books.
  
- **Models**
  - `Book.cs`: Represents the book entity with properties such as Id, Title, Author, and ISBN.
  
- **Services**
  - `BookService.cs`: Contains business logic for managing books.
  
- **Middleware**
  - `AuthenticationMiddleware.cs`: Handles user authentication for incoming requests.
  
- **Data**
  - `ApplicationDbContext.cs`: Represents the database context for accessing books.
  
- **DTOs**
  - `BookDTO.cs`: Used for data transfer, excluding sensitive data.
  
- **Program.cs**: Entry point of the application.
  
- **Startup.cs**: Configures services and the application's request pipeline.
  
- **appsettings.json**: Contains configuration settings for the application.

## Setup Instructions

1. Clone the repository:
   ```
   git clone <repository-url>
   ```

2. Navigate to the project directory:
   ```
   cd my-netcore-api
   ```

3. Restore the dependencies:
   ```
   dotnet restore
   ```

4. Run the application:
   ```
   dotnet run
   ```

## Usage

- **GET** `/api/books`: Retrieve a list of all books.
- **GET** `/api/books/{id}`: Retrieve a specific book by ID.
- **POST** `/api/books`: Create a new book.
- **PUT** `/api/books/{id}`: Update an existing book.
- **DELETE** `/api/books/{id}`: Delete a book.

## Authentication

This API includes middleware for user authentication. Ensure to include a valid authentication token in the request headers for protected endpoints.

## Contributing

Feel free to submit issues or pull requests for improvements or bug fixes.