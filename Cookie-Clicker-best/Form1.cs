using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cookie_Clicker_best
{
    public partial class Form1 : Form
    {
        int cookiePress = 1;
        int total = 0;
        int passiveIncome = 0;
        public Form1()
        {
          
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void cookie_click_btn_Click(object sender, EventArgs e)
        {
            // The Btn is not visible but the picture is so when the game starts they only see the cookie.
            total += cookiePress;

        }


        private void UpdateCookies_Tick(object sender, EventArgs e)
        {
            txt_moneyDisplay.Text = total.ToString();
        }

        private void PassiveCookies_Tick(object sender, EventArgs e)
        {
            txt_moneyDisplay.Text = PassiveCookies.ToString();
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(pictureBox3, "curser will click for you buy +1"); // you can change the first parameter (textbox3) on any control you wanna focus
        }
    }
}
