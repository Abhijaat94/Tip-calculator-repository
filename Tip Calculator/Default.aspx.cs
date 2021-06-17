using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tip_Calculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                // step 1 : input values  and stored in variables
                double Bill = double.Parse(abtxtBill.Text);
                double Tip = double.Parse(abtxtTip.Text);
                double Nop = double.Parse(abtxtNop.Text);

                // step 2 : declare the variables for output
                double TipTotal;
                double TotalAmount;

                // step 3 : perform the calculation
                TipTotal = (Bill * (Tip / 100))/Nop;
                TotalAmount = ((Bill - (TipTotal*2))/2) + (TipTotal*2);

                // step 4 : display the final result
                ablblTip.Text = TipTotal.ToString("c");
                ablblTotal.Text = TotalAmount.ToString("c");
            }
            catch(Exception ex)
            {
               string exMsg =  ex.Message;
            }
        }

        protected void abtxtBill_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
}