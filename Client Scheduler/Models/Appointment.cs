using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_Scheduler.Models
{
    public class Appointment : BaseEntity
    {
        public Appointment()
        {
            title = "";
            description = "";
            location = "";
            contact = "";
            lastUpdateBy = "";
            url = "";
        }
        [DisplayName("AppointmentId")]
        public int appointmentId { get; set; }
        [DisplayName("CustomerId")]
        public int customerId { get; set; }
        [DisplayName("UserId")]
        public int userId { get; set; }
        [Browsable(false)]
        [DisplayName("Title")]
        public string title { get; set; }
        [Browsable(false)]
        [DisplayName("Description")]
        public string description { get; set; }
        [Browsable(false)]
        [DisplayName("Location")]
        public string location { get; set; }
        [Browsable(false)]
        [DisplayName("Contact")]
        public string contact { get; set; }
        [Browsable(false)]
        [DisplayName("Url")]
        public string url { get; set; }
        [DisplayName("Type")]
        public string type { get; set; }
        [DisplayName("Start")]
        public DateTime start { get; set; }
        [DisplayName("End")]
        public DateTime end { get; set; }
        [Browsable(false)]
        [DisplayName("CreatedBy")]
        public string createdBy { get; set; }
        [Browsable(false)]
        [DisplayName("LastUpdateBy")]
        public string lastUpdateBy { get; set; }

        public string GetCustomerName()
        {
            return Service.GetCustomers().Result.Where(cust => cust.customerId == customerId).Select(name => name.customerName).FirstOrDefault();
        }
        public string GetUserName()
        {
            return Service.GetUserDetails(userId).userName;
        }
    }
}
