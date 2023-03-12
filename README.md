# Hair Salon Manager

#### By Mike Wilkes

#### A C# MVC application for a salon owner to track stylists and clients

## Technologies Used

* C#
* ASP.NET Core MVC
* MySQL
* Razor
* HTML
* Git

## Description
This is a web application that creates a website using the MVC framework and a MySQL database to manage and display data. It is designed for a salon owner to manage the stylists and clients at their salon. The user can add stylists, view and edit stylist details, and assign clients to stylists. Each client can only be assigned to one stylist based on their stylist's specialty.

## Setup instructions
- Clone this repository
- Create a .gitignore file in the project folder with the contents:
    `obj`<br>
    `bin`<br>
    `appsettings.json`
- Navigate to the HairSalon directory
- Create an appsetting.json file with the following contents, replacing the values inside brackets [] with your own:
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DB-NAME];uid=[YOUR-USER-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}
```
- In a terminal window, run:
  - `dotnet restore`
  - `dotnet run`
- In a web browser, navigate to https://localhost:5001/

## Known Bugs
The application currently will not run, for unknown reasons relating to ASP.NET Core development certificates. 
It is currently missing Client views.

## License

MIT License

Copyright (c) _2023_ _Mike Wilkes_ 