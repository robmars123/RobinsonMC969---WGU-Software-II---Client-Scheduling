using Client_Scheduler.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_Scheduler.ViewModels
{
    public class AppointmentsCalendar
    {
        public int AppointmentId { get; set; }
        [DisplayName("Consultant")]
        public string User { get; set; }
        public string Type { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }

        public int UserId { get; set; }
        [Browsable(false)]
        public Appointment appointment { get; set; }
    }
}
