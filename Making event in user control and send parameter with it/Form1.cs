using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Making_event_in_user_control_and_send_parameter_with_it
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ctrlCalculationNumbers1_OnCalculationComplete(int obj)
        {
            int Result = obj;

            MessageBox.Show("Result = " + Result.ToString());
        }
    }
}
