using AspCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace AspCore.Controllers
{
    public class HomeController : Controller
    {
        static string[] Scopes = { CalendarService.Scope.CalendarReadonly };
        public List<AppointmentData> Appointments { get; set; } = new List<AppointmentData>();
        public IActionResult Index()
        {
            CalendarService service = new CalendarService(new BaseClientService.Initializer()
            {
                ApiKey = "Your Api Key",
                ApplicationName = "you application name"
            });

            string calendarId = "your google calendar id";

            // Define a DateTime range to retrieve events
            DateTime startDate = DateTime.Now.AddDays(-30);
            DateTime endDate = DateTime.Now.AddDays(100);

            // Define the request to retrieve events
            EventsResource.ListRequest request = service.Events.List(calendarId);
            request.TimeMin = startDate;
            request.TimeMax = endDate;
            request.ShowDeleted = false;

            // Execute the calendar service request and retrieve events
            Events events = request.Execute();
            foreach (Event appointment in events.Items)
            {
                Appointments.Add(new AppointmentData()
                {
                    Subject = appointment.Summary,
                    StartTime = Convert.ToDateTime(appointment.Start.Date),
                    EndTime = Convert.ToDateTime(appointment.End.Date),
                });
            }

            List<AppointmentData> scheduleData = new List<AppointmentData>();
            scheduleData.Add(new AppointmentData
            {
                Id = 100,
                Subject = "Scheduler local data",
                StartTime = new DateTime(2024, 10, 15, 10, 0, 0),
                EndTime = new DateTime(2024, 10, 15, 12, 30, 0),
            });

            // Merge both schedule and google calendar data and assign it to the datasource of schedule

            List<AppointmentData> resultData = new List<AppointmentData>();
            resultData = Appointments.Concat(scheduleData).ToList();
            ViewBag.appointments = resultData;
            return View();
        }

        public class AppointmentData
        {
            public int Id { get; set; }
            public string Subject { get; set; }
            public DateTime StartTime { get; set; }
            public DateTime EndTime { get; set; }

        }
    }
}
