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
        [Browsable(false)]
        [DisplayName("CreateDate")]
        public DateTime createDate { get; set; }
        [Browsable(false)]
        [DisplayName("LastUpdate")]
        public DateTime lastUpdate { get; set; }
    }
}
