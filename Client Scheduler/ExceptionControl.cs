using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_Scheduler
{
    public class ExceptionControl : ApplicationException
    {
        public void OutOfBusinessHours()
        {
            MessageBox.Show("Your selected time is outside of business hours.", "Error");
        }

        public void OverlapAppointment()
        {
            MessageBox.Show("Your selected time has a conflict with existing schedules.", "Error");
        }
    }
}
