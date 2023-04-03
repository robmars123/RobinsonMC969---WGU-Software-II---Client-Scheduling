using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_Scheduler.Models
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            createDate = DateTime.UtcNow;
            lastUpdate = DateTime.UtcNow;
        }
        [Browsable(false)]
        [DisplayName("CreateDate")]
        public DateTime createDate { get; set; }
        [Browsable(false)]
        [DisplayName("LastUpdate")]
        public DateTime lastUpdate { get; set; }
    }
}
