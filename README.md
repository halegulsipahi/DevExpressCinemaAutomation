# DevExpress Cinema Automation

DevExpress Cinema Automation is a Windows desktop application for managing cinema reservations, ticket sales, movies, and customers. Cinema staff can browse movies, check seat availability, reserve multiple seats in one transaction, and review sales from the cash register dashboard.

The application is built with C# WinForms, DevExpress WinForms controls, Entity Framework 6, and SQL Server LocalDB.

## Application Demo

![Animated demo of DevExpress Cinema Automation](./assets/demo.gif)

## Features

| Feature | What you can do |
| --- | --- |
| Now Showing | Browse currently showing movies and view their posters. |
| Seat Selection | See which seats are available or occupied, select multiple seats, and review the total ticket price before confirming. |
| Ticket Reservations | Record a reservation and issue tickets for the selected seats. |
| Cash Register & Sales Reports | Review each transaction's movie, customer, ticket count, and revenue. Track order counts, seats sold, and revenue through daily and overall totals. |
| Movie Management | View, add, edit, and delete movie records. |
| Customer Management | View, add, edit, and delete customer records. |

## Screenshots

| Seat Reservation | Cash Register & Sales Reports |
| :---: | :---: |
| ![Seat reservation screen](./assets/reservation.png) | ![Cash register dashboard and sales reports](./assets/cashRegister.png) |

| Movie Management | Customer Management |
| :---: | :---: |
| ![Movie management screen](./assets/movieList.png) | ![Customer management screen](./assets/customerList.png) |

## Architecture

The solution uses an N-tier architecture that separates the desktop interface, business rules, data access, and domain models.

| Project | Responsibility |
| --- | --- |
| `DevExpressCinemaAutomation` | Presentation layer. Contains the WinForms screens and DevExpress controls used to manage movies, customers, reservations, and sales. |
| `CinemaAutomation.Business` | Business layer. Provides application services and validates business rules. |
| `CinemaAutomation.DataAccess` | Data access layer. Manages database operations and entity mappings through Entity Framework 6. |
| `CinemaAutomation.Entities` | Domain layer. Defines models such as `Movie`, `Customer`, `Seat`, `Reservation`, and `CashRegister`. |

## Getting Started

### Prerequisites

- Visual Studio 2022 with the **.NET desktop development** workload
- DevExpress WinForms components compatible with the project references
- SQL Server LocalDB

### Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/halegulsipahi/DevExpressCinemaAutomation.git
   ```

2. Open `DevExpressCinemaAutomation.sln` in Visual Studio.
3. Right-click the solution in **Solution Explorer** and select **Restore NuGet Packages**.
4. Open `DevExpressCinemaAutomation/App.config`. In the `connectionStrings` section, check that the configured SQL Server instance matches your local installation. Update the connection string if needed.
5. In **Solution Explorer**, right-click `DevExpressCinemaAutomation` and select **Set as Startup Project**.
6. Press **F5** to build and run the application. Entity Framework initializes the database on first run.

### Optional Movie Posters

To show posters in the **Now Showing** panel, create a `Posters` folder in the application's output directory. For a Debug build, use `DevExpressCinemaAutomation/bin/Debug/Posters/`.

Save each poster as a `.jpg` file named after its movie ID. For example, use `1.jpg` for movie ID `1` and `2.jpg` for movie ID `2`.
