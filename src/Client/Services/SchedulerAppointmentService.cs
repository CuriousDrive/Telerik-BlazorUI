using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BookStores.Models;

namespace BookStores.Services
{
    public class SchedulerAppointmentService
    {
        public async Task<List<SchedulerAppointment>> GetAppointmentsAsync()
        {
            return await GetDummyAppointments();
        }

        public async Task<List<SchedulerAppointment>> GetRecurringAppointmentsAsync()
        {
            return await GetRecurringAppointments();
        }

        public async Task<List<SchedulerAppointment>> GetTemplateAppointmentsAsync()
        {
            return await GetTemplateAppointments();
        }

        private async Task<List<SchedulerAppointment>> GetDummyAppointments()
        {
            List<SchedulerAppointment> data = new List<SchedulerAppointment>();
            DateTime baselineTime = GetStartTime();

            data.Add(new SchedulerAppointment
            {
                Title = "Vet visit",
                Description = "The cat needs vaccinations and her teeth checked.",
                Start = baselineTime.AddHours(2),
                End = baselineTime.AddHours(2).AddMinutes(30),
                Room = "1",
                Manager = "2"
            });

            data.Add(new SchedulerAppointment
            {
                Title = "Trip to Hawaii",
                Description = "An unforgettable holiday!",
                IsAllDay = true,
                Start = baselineTime.AddDays(-10),
                End = baselineTime.AddDays(-2),
                Room = "2",
                Manager = "1"
            });

            data.Add(new SchedulerAppointment
            {
                Title = "Jane's birthday party",
                Description = "Make sure to get her fresh flowers in addition to the gift.",
                Start = baselineTime.AddDays(5).AddHours(10),
                End = baselineTime.AddDays(5).AddHours(18),
                Room = "1",
                Manager = "2"
            });

            data.Add(new SchedulerAppointment
            {
                Title = "One-on-one with the manager",
                Start = baselineTime.AddHours(3).AddMinutes(30),
                End = baselineTime.AddHours(3).AddMinutes(45),
                Room = "1",
                Manager = "3",
                RecurrenceRule = "FREQ=MONTHLY;BYDAY=MO;BYSETPOS=2"
            });

            data.Add(new SchedulerAppointment
            {
                Title = "Brunch with HR",
                Description = "Performance evaluation of the new recruit.",
                Start = baselineTime.AddDays(3).AddHours(3),
                End = baselineTime.AddDays(3).AddHours(3).AddMinutes(45),
                Room = "1",
                Manager = "3"
            });

            data.Add(new SchedulerAppointment
            {
                Title = "Interview with new recruit",
                Description = "See if John will be a suitable match for our team.",
                Start = baselineTime.AddDays(3).AddHours(1).AddMinutes(30),
                End = baselineTime.AddDays(3).AddHours(2).AddMinutes(30),
                Room = "2",
                Manager = "1"
            });

            data.Add(new SchedulerAppointment
            {
                Title = "Conference",
                Description = "The big important work conference. Don't forget to practice your presentation.",
                Start = baselineTime.AddDays(6),
                End = baselineTime.AddDays(11),
                IsAllDay = true,
                Room = "1",
                Manager = "1"
            });

            data.Add(new SchedulerAppointment
            {
                Title = "New Project Kickoff",
                Description = "Everyone assemble! We will also have clients on the call from a later time zone.",
                Start = baselineTime.AddDays(3).AddHours(8).AddMinutes(30),
                End = baselineTime.AddDays(3).AddHours(11).AddMinutes(30),
                Room = "2",
                Manager = "2"
            });

            data.Add(new SchedulerAppointment
            {
                Title = "Get photos",
                Description = "Get the printed photos from last week's holiday. It's on the way from the vet to work.",
                Start = baselineTime.AddHours(2).AddMinutes(15),
                End = baselineTime.AddHours(2).AddMinutes(30),
                Room = "2",
                Manager = "3"
            });

            data.Add(new SchedulerAppointment
            {
                Title = "Morning run",
                Description = "Some time to clear the head and exercise.",
                Start = baselineTime.AddDays(-10).AddHours(1),
                End = baselineTime.AddDays(-10).AddHours(1).AddMinutes(30),
                Room = "2",
                Manager = "1",
                RecurrenceRule = "FREQ=WEEKLY;BYDAY=MO,TU,WE,TH,FR"
            });

            return await Task.FromResult(data);
        }

        private async Task<List<SchedulerAppointment>> GetRecurringAppointments()
        {
            List<SchedulerAppointment> data = new List<SchedulerAppointment>();
            DateTime baselineTime = GetStartTime();

            data.Add(new SchedulerAppointment
            {
                Title = "Daily scrum",
                Description = "Meet with teammates and discuss work issues",
                Start = baselineTime.AddDays(-7).AddHours(2).AddMinutes(30),
                End = baselineTime.AddDays(-7).AddHours(3),
                RecurrenceRule = "FREQ=WEEKLY;BYDAY=MO,TU,WE,TH,FR"
            });

            data.Add(new SchedulerAppointment
            {
                Title = "Team breakfast",
                Description = "Have breakfast with teammates every couple of days",
                Start = baselineTime.AddDays(-7).AddHours(1),
                End = baselineTime.AddDays(-7).AddHours(1).AddMinutes(30),
                RecurrenceRule = "FREQ=WEEKLY;BYDAY=TU,TH"
            });

            data.Add(new SchedulerAppointment
            {
                Title = "Monthly doctor checkup",
                Description = "Visit the doctor and make sure all vitals are good",
                Start = baselineTime.AddHours(4),
                End = baselineTime.AddHours(5),
                RecurrenceRule = $"FREQ=MONTHLY;BYMONTHDAY={baselineTime.Day}"
            });

            data.Add(new SchedulerAppointment
            {
                Title = "Tim's birthday",
                Description = "Don't forget brother's b-day",
                Start = baselineTime.AddDays(2).AddHours(8),
                End = baselineTime.AddDays(2).AddHours(9),
                RecurrenceRule = $"FREQ=YEARLY;BYMONTH={baselineTime.AddDays(2).Month};BYMONTHDAY={baselineTime.AddDays(2).Day}"
            });

            return await Task.FromResult(data);
        }

        private async Task<List<SchedulerAppointment>> GetTemplateAppointments()
        {
            List<SchedulerAppointment> data = new List<SchedulerAppointment>();

            data.Add(new SchedulerAppointment
            {
                Title = "Requirement analysis",
                Start = new DateTime(2020, 10, 5, 8, 30, 0),
                End = new DateTime(2020, 10, 5, 9, 30, 0),
                Department = "PM"
            });

            data.Add(new SchedulerAppointment
            {
                Title = "Catch-up",
                Start = new DateTime(2020, 10, 5, 10, 0, 0),
                End = new DateTime(2020, 10, 5, 10, 30, 0),
                Department = "Development"
            });

            data.Add(new SchedulerAppointment
            {
                Title = "User interview",
                Start = new DateTime(2020, 10, 5, 10, 30, 0),
                End = new DateTime(2020, 10, 5, 12, 0, 0),
                Department = "Design"
            });

            data.Add(new SchedulerAppointment
            {
                Title = "Accessibility research",
                Start = new DateTime(2020, 10, 5, 13, 30, 0),
                End = new DateTime(2020, 10, 5, 15, 0, 0),
                Department = "Design"
            });

            data.Add(new SchedulerAppointment
            {
                Title = "Sprint planning",
                Start = new DateTime(2020, 10, 5, 15, 30, 0),
                End = new DateTime(2020, 10, 5, 16, 30, 0),
                Department = "Development"
            });

            data.Add(new SchedulerAppointment
            {
                Title = "Bug fixes report presentation",
                Start = new DateTime(2020, 10, 6, 10, 30, 0),
                End = new DateTime(2020, 10, 6, 11, 30, 0),
                Department = "Development"
            });

            data.Add(new SchedulerAppointment
            {
                Title = "Risk management",
                Start = new DateTime(2020, 10, 6, 12, 30, 0),
                End = new DateTime(2020, 10, 6, 14, 0, 0),
                Department = "PM"
            });

            data.Add(new SchedulerAppointment
            {
                Title = "Prototype presentation",
                Start = new DateTime(2020, 10, 6, 14, 30, 0),
                End = new DateTime(2020, 10, 6, 15, 30, 0),
                Department = "Design"
            });

            data.Add(new SchedulerAppointment
            {
                Title = "Refinement",
                Start = new DateTime(2020, 10, 6, 16, 30, 0),
                End = new DateTime(2020, 10, 6, 17, 0, 0),
                Department = "PM"
            });

            data.Add(new SchedulerAppointment
            {
                Title = "Testing training",
                Start = new DateTime(2020, 10, 7, 9, 0, 0),
                End = new DateTime(2020, 10, 7, 11, 30, 0),
                Department = "Development"
            });

            data.Add(new SchedulerAppointment
            {
                Title = "User documentation revision",
                Start = new DateTime(2020, 10, 7, 13, 30, 0),
                End = new DateTime(2020, 10, 7, 14, 30, 0),
                Department = "PM"
            });

            data.Add(new SchedulerAppointment
            {
                Title = "Risk estimation",
                Start = new DateTime(2020, 10, 7, 15, 0, 0),
                End = new DateTime(2020, 10, 7, 15, 30, 0),
                Department = "Development"
            });

            data.Add(new SchedulerAppointment
            {
                Title = "Project proposal estimation",
                Start = new DateTime(2020, 10, 8, 8, 0, 0),
                End = new DateTime(2020, 10, 8, 9, 0, 0),
                Department = "PM"
            });

            data.Add(new SchedulerAppointment
            {
                Title = "Blogposts and communication",
                Start = new DateTime(2020, 10, 8, 9, 30, 0),
                End = new DateTime(2020, 10, 8, 10, 30, 0),
                Department = "PM"
            });

            data.Add(new SchedulerAppointment
            {
                Title = "Demo revision",
                Start = new DateTime(2020, 10, 8, 10, 30, 0),
                End = new DateTime(2020, 10, 8, 11, 0, 0),
                Department = "Design"
            });

            data.Add(new SchedulerAppointment
            {
                Title = "Weekly sync-up",
                Start = new DateTime(2020, 10, 8, 14, 0, 0),
                End = new DateTime(2020, 10, 8, 14, 30, 0),
                Department = "Design"
            });

            data.Add(new SchedulerAppointment
            {
                Title = "Cross-team alignment",
                Start = new DateTime(2020, 10, 8, 15, 30, 0),
                End = new DateTime(2020, 10, 8, 16, 30, 0),
                Department = "Development"
            });

            data.Add(new SchedulerAppointment
            {
                Title = "Montly planning",
                Start = new DateTime(2020, 10, 9, 8, 30, 0),
                End = new DateTime(2020, 10, 9, 9, 30, 0),
                Department = "Development"
            });

            data.Add(new SchedulerAppointment
            {
                Title = "Retrospective meeting",
                Start = new DateTime(2020, 10, 9, 9, 30, 0),
                End = new DateTime(2020, 10, 9, 10, 30, 0),
                Department = "Development"
            });

            data.Add(new SchedulerAppointment
            {
                Title = "Review beta users feedback",
                Start = new DateTime(2020, 10, 9, 11, 0, 0),
                End = new DateTime(2020, 10, 9, 12, 0, 0),
                Department = "Design"
            });

            data.Add(new SchedulerAppointment
            {
                Title = "Project kick-off",
                Start = new DateTime(2020, 10, 9, 12, 30, 0),
                End = new DateTime(2020, 10, 9, 14, 0, 0),
                Department = "PM"
            });

            return await Task.FromResult(data);
        }

        public DateTime GetStartTime()
        {
            DateTime now = DateTime.Now;
            int diff = (7 + (now.DayOfWeek - DayOfWeek.Monday)) % 7;
            DateTime lastMonday = now.AddDays(-1 * diff);
            // return 8 AM on today's date for better visualization of the demos
            return new DateTime(lastMonday.Year, lastMonday.Month, lastMonday.Day, 8, 0, 0);
        }
    }
}