using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OX001
{
    public partial class oxx : System.Web.UI.Page
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

            if(Convert.ToString(Application["oxturn"]) == "O")
                { Image1.Visible = true;Image2.Visible = false; }
            if (Convert.ToString(Application["oxturn"]) == "X")
            { Image1.Visible = false; Image2.Visible = true; }

            if (Convert.ToString(Application["oxwin"]) == "O")
            { loseImg.Visible = true; }
            else if (Convert.ToString(Application["oxwin"]) == "X")
            { winImg.Visible = true; }
            else if (Convert.ToString(Application["oxwin"]) == "-")
            { tieImg.Visible = true; }
            else if (Convert.ToString(Application["oxwin"]) == ".")
            { loseImg.Visible = false; winImg.Visible = false; tieImg.Visible = false; }

        }

        protected void win()
        {
            if (Application["ox1"] == "X" && Application["ox2"] == "X" && Application["ox3"] == "X")
            { Application["oxwin"] = "X"; }
            if (Application["ox4"] == "X" && Application["ox5"] == "X" && Application["ox6"] == "X")
            { Application["oxwin"] = "X"; }
            if (Application["ox7"] == "X" && Application["ox8"] == "X" && Application["ox9"] == "X")
            { Application["oxwin"] = "X"; }

            if (Application["ox1"] == "X" && Application["ox4"] == "X" && Application["ox7"] == "X")
            { Application["oxwin"] = "X"; }
            if (Application["ox2"] == "X" && Application["ox5"] == "X" && Application["ox8"] == "X")
            { Application["oxwin"] = "X"; }
            if (Application["ox3"] == "X" && Application["ox6"] == "X" && Application["ox9"] == "X")
            { Application["oxwin"] = "X"; }

            if (Application["ox1"] == "X" && Application["ox5"] == "X" && Application["ox9"] == "X")
            { Application["oxwin"] = "X"; }
            if (Application["ox3"] == "X" && Application["ox5"] == "X" && Application["ox7"] == "X")
            { Application["oxwin"] = "X"; }

            if (Application["ox1"] != "" && Application["ox2"] != "" && Application["ox3"] != "" && Application["ox4"] != "" && Application["ox5"] != "" && Application["ox6"] != "" && Application["ox7"] != "" && Application["ox8"] != "" && Application["ox9"] != "")
            { Application["oxwin"] = "-"; }

        }

        protected void ImageButton1_Click(object sender, EventArgs e)
        {
            if (Application["oxturn"] == "X" && Application["oxwin"] == "." && Application["ox1"] == "")
            {
                Application["ox1"] = "X";
                Application["oxturn"] = "O";
                win();
            }
        }

        protected void ImageButton2_Click(object sender, EventArgs e)
        {
            if (Application["oxturn"] == "X" && Application["oxwin"] == "." && Application["ox2"] == "")
            {
                Application["ox2"] = "X";
                Application["oxturn"] = "O";
                win();
            }
        }

        protected void ImageButton3_Click(object sender, EventArgs e)
        {
            if (Application["oxturn"] == "X" && Application["oxwin"] == "." && Application["ox3"] == "")
            {
                Application["ox3"] = "X";
                Application["oxturn"] = "O"; 
                win();
            }
        }

        protected void ImageButton4_Click(object sender, EventArgs e)
        {
            if (Application["oxturn"] == "X" && Application["oxwin"] == "." && Application["ox4"] == "")
            {
                Application["ox4"] = "X";
                Application["oxturn"] = "O";
                win();
            }
        }

        protected void ImageButton5_Click(object sender, EventArgs e)
        {
            if (Application["oxturn"] == "X" && Application["oxwin"] == "." && Application["ox5"] == "")
            {
                Application["ox5"] = "X";
                Application["oxturn"] = "O"; 
                win();
            }
        }

        protected void ImageButton6_Click(object sender, EventArgs e)
        {
            if (Application["oxturn"] == "X" && Application["oxwin"] == "." && Application["ox6"] == "")
            {
                Application["ox6"] = "X";
                Application["oxturn"] = "O";
                win();
            }
        }

        protected void ImageButton7_Click(object sender, EventArgs e)
        {
            if (Application["oxturn"] == "X" && Application["oxwin"] == "." && Application["ox7"] == "")
            {
                Application["ox7"] = "X";
                Application["oxturn"] = "O";
                win();
            }
        }

        protected void ImageButton8_Click(object sender, EventArgs e)
        {
            if (Application["oxturn"] == "X" && Application["oxwin"] == "." && Application["ox8"] == "")
            {
                Application["ox8"] = "X";
                Application["oxturn"] = "O";
                win();
            }
        }

        protected void ImageButton9_Click(object sender, EventArgs e)
        {
            if (Application["oxturn"] == "X" && Application["oxwin"] == "." && Application["ox9"] == "")
            {
                Application["ox9"] = "X";
                Application["oxturn"] = "O";
                win();
            }
        }

    }
}