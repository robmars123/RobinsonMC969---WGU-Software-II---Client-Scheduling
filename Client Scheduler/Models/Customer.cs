using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Client_Scheduler.Models
{
    public class Customer : BaseEntity
    {
        public Customer()
        {
            createDate = DateTime.Now;
            lastUpdate = DateTime.Now;
        }
        [Key]
        [DisplayName("CustomerID")]
        public int customerId { get; set; }
        [DisplayName("Customer Name")]
        public string customerName { get; set; }
        [DisplayName("Address ID")]
        public int addressId { get; set; }
        [DisplayName("IsActive")]
        public bool active { get; set; }
        [DisplayName("Created By")]
        public string createdBy { get; set; }
        [DisplayName("Last Updated By")]
        public string lastUpdateBy { get; set; }
        [Browsable(false)]
        [NotMapped]
        public virtual Address address { get; set; }
        public string GetAddressName()
        {
            return Service.GetAddressQuery(addressId).address;
        }
    }
}
