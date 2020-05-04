using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalWebApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnaddd_Click(object sender, EventArgs e)
        {
            calServiceReference.CalculatorWebServiceSoapClient client = new calServiceReference.CalculatorWebServiceSoapClient();
            int result = client.add(Convert.ToInt32(txtFirstNumber.Text), Convert.ToInt32(txtSecondNumber.Text));
            lblResult.Text = result.ToString();
        }
    }
}