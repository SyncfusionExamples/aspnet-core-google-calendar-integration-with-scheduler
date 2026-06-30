# ASP.NET Core Scheduler Google Calendar Integration Using Syncfusion EJ2

A sample project that demonstrates how to integrate Google Calendar events into the [ASP.NET Core Scheduler](https://www.syncfusion.com/aspnet-core-ui-controls/scheduler), enabling synchronization of external calendar data with existing scheduler events. This example showcases fetching and managing Google Calendar events alongside local data, providing a seamless and unified scheduling experience within an ASP.NET Core application.

## Technologies Used

* ASP.NET Core
* C#
* Syncfusion EJ2 Scheduler for ASP.NET Core
* Google Calendar API
* Entity Framework Core

## Prerequisites

* Visual Studio 2022
* .NET 6.0 or later
* Google calendar API key - You can generate the API key by following the steps mentioned in this [link](https://support.google.com/googleapi/answer/6158862?hl=en)
* Google calendar ID - You can find the ID of your calendar in the Google Calendar settings

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
