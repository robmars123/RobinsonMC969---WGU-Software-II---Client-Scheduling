using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_Scheduler.Models
{
    public class Address : BaseEntity
    {
        public Address()
        {
            createDate = DateTime.Now;
            lastUpdate = DateTime.Now;
        }
        [Key]
        public int addressId { get; set; }
        public string address { get; set; }
        public string address2 { get; set; }
        public int? cityId { get; set; }
        public string postalCode { get; set; }
        public string phone { get; set; }
        public string createdBy { get; set; }
        public string lastUpdateBy { get; set; }
        [NotMapped]
        public virtual City city { get; set; }
    }
}
