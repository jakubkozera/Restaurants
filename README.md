# Restaurants API

This is a .NET 8.0 web API for managing restaurants, following the principles of Clean Architecture.

## Video Course

This solution is part of a video course. 

You can find the course at [https://linktr.ee/fullstack_developer](https://linktr.ee/fullstack_developer). 

The course covers the development of this .NET 8.0 web API for managing restaurants, following the principles of Clean Architecture, in detail.

## Project Structure

- `src/Restaurants.API`: The main API project. This is the entry point of the application.
- `src/Restaurants.Application`: Contains the application logic. This layer is responsible for the application's behavior and policies.
- `src/Restaurants.Domain`: Contains enterprise logic and types. This is the core layer of the application.
- `src/Restaurants.Infrastructure`: Contains infrastructure-related code such as database and file system interactions. This layer supports the higher layers.
- `tests/Restaurants.API.Tests`: Contains unit tests for the API.


## Packages and Libraries

This project uses several NuGet packages and libraries to achieve its functionality:

- **Serilog**: This library is used for logging. It provides a flexible and easy-to-use logging API.

- **MediatR**: This library is used to implement the Command Query Responsibility Segregation (CQRS) pattern. In this solution, commands (which change the state of the system) and queries (which read the state) are separated for clarity and ease of development.

- **Entity Framework**: This is an open-source ORM framework for .NET. It enables developers to work with data using objects of domain-specific classes without focusing on the underlying database tables and columns where this data is stored.

- **Azure Storage Account**: This service is used for handling blobs. Blobs, or Binary Large Objects, are a type of data that can hold large amounts of unstructured data such as text or binary data, including images, documents, streaming media, and archive data.

- **Microsoft Identity Package**: This package is used for handling user identity in the web API. It provides features such as authentication, authorization, identity, and user access control.

Please refer to the official documentation of each package for more details and usage examples.

## Getting Started

### Prerequisites

- .NET 8.0
- Visual Studio 2022 or later

### Building

To build the project, open the `Restaurants.sln` file in Visual Studio and build the solution.

### Running

To run the project, set `Restaurants.API` as the startup project in Visual Studio and start the application.

## API Endpoints

1. `GET /api/restaurants`
   - Parameters: `searchPhrase`, `pageSize`, `pageNumber`, `sortBy`, `sortDirection`
   - Authorization Bearer token

2. `GET /api/restaurants/{id}`
   - Parameters: `id`
   - Authorization: Bearer token

3. `GET /api/restaurants/{id}/dishes`
   - Parameters: `id`
   - Authorization: Bearer token

4. `DELETE /api/restaurants/{id}/dishes`
   - Parameters: `id`

5. `GET /api/restaurants/{id}/dishes/{dishId}`
   - Parameters: `id`, `dishId`

6. `DELETE /api/restaurants/{id}`
   - Parameters: `id`
   - Authorization: Bearer token

7. `POST /api/restaurants`
   - Body: JSON object with properties `Name`, `Description`, `Category`, `HasDelivery`, `ContactEmail`, `ContactNumber`, `City`, `Street`
   - Authorization: Bearer token

## Testing

The tests are located in the `tests/*` directory. You can run them using the test runner in Visual Studio.

 
