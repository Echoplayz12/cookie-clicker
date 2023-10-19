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
            
        }

        //updates the text box with the total amount of cookies you have
        private void UpdateCookies_Tick(object sender, EventArgs e)
        {
            txt_moneyDisplay.Text = total.ToString();
        }

        //this adds the passive cookies with the total amount of cookies you have 
        private void PassiveCookies_Tick(object sender, EventArgs e)
        {
            total += passiveIncome;
        }
        
        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(pictureBox3, "curser will click for you buy"); // you can change the first parameter (textbox3) on any control you wanna focus
        }

        //this is the first upgrade you get it adds +1 to your passive cookies 
        private void Btn_hand_Click(object sender, EventArgs e)
        {
        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // The Btn is not visible but the picture is so when the game starts they only see the cookie.
            total += cookiePress;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // if you dont have the money then you get a error message but if you do then the money you have will be subtracted by the cost then +1 will be added 
            int handUpgrade = 1;
            if (total > 100)
            {
                passiveIncome += handUpgrade;
                int handUpgradesub = 100;
                total -= handUpgradesub;
            }
            else
            {
                MessageBox.Show("You dont have the sufficant funds", "error", MessageBoxButtons.OK);
            }
        }
    }   
}
