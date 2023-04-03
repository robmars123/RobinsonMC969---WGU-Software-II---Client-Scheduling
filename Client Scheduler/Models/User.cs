using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_Scheduler.Models
{
    public class User : BaseEntity
    {
        public int userId { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public sbyte active { get; set; }
        public string createdBy { get; set; }
        public string lastUpdateBy { get; set; }
    }
}
