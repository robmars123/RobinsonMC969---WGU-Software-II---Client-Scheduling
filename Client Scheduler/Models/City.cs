using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_Scheduler.Models
{
    public class City: BaseEntity
    {
        public City()
        {
            createDate = DateTime.Now;
            lastUpdate = DateTime.Now;
        }
        [Key]
        public int cityId { get; set; }
        public string city { get; set; }
        public int? countryId { get; set; }
        public string createdBy { get; set; }
        public string lastUpdateBy { get; set; }
        [NotMapped]
        public virtual Country country { get; set; }
    }
}
