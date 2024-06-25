using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OX001
{
    public partial class oxo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            ImageButton1.ImageUrl = "Buttom_" + Convert.ToString(Application["ox1"]) + ".png";
            ImageButton2.ImageUrl = "Buttom_" + Convert.ToString(Application["ox2"]) + ".png";
            ImageButton3.ImageUrl = "Buttom_" + Convert.ToString(Application["ox3"]) + ".png";
            ImageButton4.ImageUrl = "Buttom_" + Convert.ToString(Application["ox4"]) + ".png";
            ImageButton5.ImageUrl = "Buttom_" + Convert.ToString(Application["ox5"]) + ".png";
            ImageButton6.ImageUrl = "Buttom_" + Convert.ToString(Application["ox6"]) + ".png";
            ImageButton7.ImageUrl = "Buttom_" + Convert.ToString(Application["ox7"]) + ".png";
            ImageButton8.ImageUrl = "Buttom_" + Convert.ToString(Application["ox8"]) + ".png";
            ImageButton9.ImageUrl = "Buttom_" + Convert.ToString(Application["ox9"]) + ".png";

            Label1.Text = Convert.ToString(Application["oxturn"]);

            if (Convert.ToString(Application["oxturn"]) == "O")
            { Label3.Text = "<img src='O.png' style='width: 100px; height:135px;'>"; }
            if (Convert.ToString(Application["oxturn"]) == "X")
            { Label3.Text = "<img src='X.png' style='width: 100px; height:135px;'>"; }

            if (Convert.ToString(Application["oxwin"]) == "X")
            { loseImg.Visible = true; }
            else if (Convert.ToString(Application["oxwin"]) == "O")
            { winImg.Visible = true; }
            else if (Convert.ToString(Application["oxwin"]) == "-")
            { tieImg.Visible = true; }
            else if (Convert.ToString(Application["oxwin"]) == ".")
            { loseImg.Visible = false; winImg.Visible = false; tieImg.Visible = false; }

        }

        protected void win()
        {
            if (Application["ox1"] == "O" && Application["ox2"] == "O" && Application["ox3"] == "O")
            { Application["oxwin"] = "O"; }
            if (Application["ox4"] == "O" && Application["ox5"] == "O" && Application["ox6"] == "O")
            { Application["oxwin"] = "O"; }
            if (Application["ox7"] == "O" && Application["ox8"] == "O" && Application["ox9"] == "O")
            { Application["oxwin"] = "O"; }

            if (Application["ox1"] == "O" && Application["ox4"] == "O" && Application["ox7"] == "O")
            { Application["oxwin"] = "O"; }
            if (Application["ox2"] == "O" && Application["ox5"] == "O" && Application["ox8"] == "O")
            { Application["oxwin"] = "O"; }
            if (Application["ox3"] == "O" && Application["ox6"] == "O" && Application["ox9"] == "O")
            { Application["oxwin"] = "O"; }

            if (Application["ox1"] == "O" && Application["ox5"] == "O" && Application["ox9"] == "O")
            { Application["oxwin"] = "O"; }
            if (Application["ox3"] == "O" && Application["ox5"] == "O" && Application["ox7"] == "O")
            { Application["oxwin"] = "O"; }

            if (Application["ox1"] != "" && Application["ox2"] != "" && Application["ox3"] != "" && Application["ox4"] != "" && Application["ox5"] != "" && Application["ox6"] != "" && Application["ox7"] != "" && Application["ox8"] != "" && Application["ox9"] != "")
            { Application["oxwin"] = "-"; }
        }

        protected void ImageButton1_Click(object sender, EventArgs e)
        {
            if(Application["oxturn"] == "O" && Application["oxwin"] == "." && Application["ox1"] == "")
            {
                Application["ox1"] = "O";
                Application["oxturn"] = "X";
                win();
            }
        }

        protected void ImageButton2_Click(object sender, EventArgs e)
        {
            if (Application["oxturn"] == "O" && Application["oxwin"] == "." && Application["ox2"] == "")
            {
                Application["ox2"] = "O";
                Application["oxturn"] = "X";
                win();
            }
        }

        protected void ImageButton3_Click(object sender, EventArgs e)
        {
            if (Application["oxturn"] == "O" && Application["oxwin"] == "." && Application["ox3"] == "")
            {
                Application["ox3"] = "O";
                Application["oxturn"] = "X";
                win();
            }
        }

        protected void ImageButton4_Click(object sender, EventArgs e)
        {
            if (Application["oxturn"] == "O" && Application["oxwin"] == "." && Application["ox4"] == "")
            {
                Application["ox4"] = "O";
                Application["oxturn"] = "X";
                win();
            }
        }

        protected void ImageButton5_Click(object sender, EventArgs e)
        {
            if (Application["oxturn"] == "O" && Application["oxwin"] == "." && Application["ox5"] == "")
            {
                Application["ox5"] = "O";
                Application["oxturn"] = "X";
                win();
            }
        }

        protected void ImageButton6_Click(object sender, EventArgs e)
        {
            if (Application["oxturn"] == "O" && Application["oxwin"] == "." && Application["ox6"] == "")
            {
                Application["ox6"] = "O";
                Application["oxturn"] = "X";
                win();
            }
        }

        protected void ImageButton7_Click(object sender, EventArgs e)
        {
            if (Application["oxturn"] == "O" && Application["oxwin"] == "." && Application["ox7"] == "")
            {
                Application["ox7"] = "O";
                Application["oxturn"] = "X";
                win();
            }
        }

        protected void ImageButton8_Click(object sender, EventArgs e)
        {
            if (Application["oxturn"] == "O" && Application["oxwin"] == "." && Application["ox8"] == "")
            {
                Application["ox8"] = "O";
                Application["oxturn"] = "X";
                win();
            }
        }

        protected void ImageButton9_Click(object sender, EventArgs e)
        {
            if (Application["oxturn"] == "O" && Application["oxwin"] == "." && Application["ox9"] == "")
            {
                Application["ox9"] = "O";
                Application["oxturn"] = "X";
                win();
            }
        }
    }
}