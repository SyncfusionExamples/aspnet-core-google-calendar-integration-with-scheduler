# aspnet-core-google-calendar-integration-with-scheduler

## Repository Description

This sample demonstrates how to integrate Google Calendar events into a Syncfusion ASP.NET Core Scheduler while maintaining existing events. The project provides a comprehensive solution for synchronizing Google Calendar data with the Syncfusion Scheduler component, enabling seamless event management and scheduling capabilities within an ASP.NET Core application.

## Project Overview

This project showcases a practical implementation of integrating third-party calendar services with Syncfusion's robust scheduling solution. It enables developers to:

* Fetch events from Google Calendar
* Synchronize Google Calendar events with Syncfusion Scheduler
* Manage existing and imported events simultaneously
* Maintain real-time calendar synchronization

## Prerequisites

* Visual Studio 2022
* .NET 6.0 or later
* Google calendar API key - You can generate the API key by following the steps mentioned in this [link](https://support.google.com/googleapi/answer/6158862?hl=en)
* Google calendar ID - You can find the ID of your calendar in the Google Calendar settings
* Syncfusion ASP.NET Core Scheduler library

## How to run the project

* Checkout this project to a location in your disk
* Open the solution file using Visual Studio 2022
* Restore the NuGet packages by rebuilding the solution
* Add the API key and calendar ID into the HomeController.cs file
* Configure Google Calendar API credentials in your project settings
* Run the project and navigate to the Scheduler component

## Documentation

For more detailed information, refer to the Syncfusion ASP.NET Core documentation:

* [ASP.NET Core Introduction](https://ej2.syncfusion.com/aspnetcore/documentation/introduction)
* [ASP.NET Core Schedule Component Documentation](https://ej2.syncfusion.com/aspnetcore/documentation/schedule/getting-started)

## Technologies Used

* ASP.NET Core
* C#
* Syncfusion EJ2 Scheduler for ASP.NET Core
* Google Calendar API
* Entity Framework Core
