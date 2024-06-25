using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OX001
{
    public partial class oxm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "Init!";
            Application["ox1"] = "";
            Application["ox2"] = "";
            Application["ox3"] = "";
            Application["ox4"] = "";
            Application["ox5"] = "";
            Application["ox6"] = "";
            Application["ox7"] = "";
            Application["ox8"] = "";
            Application["ox9"] = "";
            Application["oxturn"] = "O";
            Application["oxwin"] = ".";
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            if (Convert.ToString(Application["oxwin"]) != "." && Convert.ToString(Application["oxwin"]) != "")
            { Label1.Text = "Restart?"; }
        }
    }
}