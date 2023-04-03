using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_Scheduler.ViewModels
{
    public class AppointmentStatusListReport
    {
        public string CustomerName { get; set; }
        public string Status { get; set; }
        public DateTime Start { get; set; }
    }
}
