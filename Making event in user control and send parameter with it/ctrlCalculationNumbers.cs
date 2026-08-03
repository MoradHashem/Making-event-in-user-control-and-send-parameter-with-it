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
    public partial class ctrlCalculationNumbers : UserControl
    {

        public event Action<int> OnCalculationComplete;

        protected virtual void CalculationComplete(int PersonID)
        {
            Action<int> Handler = OnCalculationComplete;

            if(Handler != null)
            {
                Handler(PersonID);
            }
        }




        public ctrlCalculationNumbers()
        {
            InitializeComponent();
        }

        private void btnCalculation_Click(object sender, EventArgs e)
        {
            int Result = Convert.ToInt32(txtNumber1.Text) + Convert.ToInt32(txtNumber2.Text);
            lblResult.Text = Result.ToString();


            if(OnCalculationComplete != null)
                CalculationComplete(Result);
        }
    }
}
