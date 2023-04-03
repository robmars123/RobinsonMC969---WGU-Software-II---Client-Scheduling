using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_Scheduler.Models
{
    public class Country : BaseEntity
    {
        public Country()
        {
            createDate = DateTime.Now;
            lastUpdate = DateTime.Now;
        }
        [Key]
        public int countryId { get; set; }
        public string country { get; set; }
        public string createdBy { get; set; }
        public string lastUpdateBy { get; set; }
    }
}
