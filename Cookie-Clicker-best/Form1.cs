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
        #region
        Double cookiePress = 1;
        Double total = 0;
        Double passiveIncome = 0;
        Double Upgradesub = 100;
        int handUpgrade = 1;

        #endregion
        public Form1()
        {
            InitializeComponent();
            label1.Text = "cost:" + 100.ToString();
        }

        //updates the text box with the total amount of cookies you have
        private void UpdateCookies_Tick(object sender, EventArgs e)
        {
            txt_moneyDisplay.Text = Math.Round(total).ToString();
        }

        //this adds the passive cookies with the total amount of cookies you have 
        private void PassiveCookies_Tick(object sender, EventArgs e)
        {
            total += passiveIncome;
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            // you can change the first parameter (textbox3) on any control you wanna focus
            toolTip1.SetToolTip(pictureBox3, "curser will click for you buy");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // The Btn is not visible but the picture is so when the game starts they only see the cookie.
            total += cookiePress;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // if you dont have the money then you get a error message but if you do then the money you have will be subtracted by the cost then +1 will be added 
            // sub is the the subtracting varible

            if (Buy(Upgradesub, 1))
            {
                Upgradesub *= 1.05;
                label1.Text = "cost:" + ((int)Upgradesub).ToString();
            }
        }

        private bool Buy(Double cost, double passiveIncomeIncrease)
        {
            if (cost <= total)
            {
                total -= cost;
                passiveIncome += passiveIncomeIncrease;
                return true;
            }
            else
            {
                MessageBox.Show("You dont have the sufficant funds", "error", MessageBoxButtons.OK);
                return false;
            }
        }
    }
}
