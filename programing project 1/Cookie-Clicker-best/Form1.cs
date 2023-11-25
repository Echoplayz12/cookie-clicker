using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Cookie_Clicker_best
{
    public partial class Form1 : Form
    {
        //int x = Point
        // int y = 0
        /*
         * put comments here <-----
         * 
         * 
         * 
         */
        /*
         * Name: Owen
         * Barely any upgrades
         * Powerups page is blank
         * Economy is in shambles
         * Only 1 ability and barely works
         * The name of the bakery uses improper syntax
         * "Cookies-ps" is horrid
         */
        /*
         * Name: Matthew K
         * Remarkably complicated
         */

        #region cost functions
        Double cookiePress = 1;
        Double total = 500;
        Double passiveIncome = 0;
        Double Upgradesub = 100;
        Double gramCost = 300;
        Double dogeCost = 500;
        Double gokuCost = 2000;
        Double cookieDrillCost = 5000;
        Double newDirllCost = 10000;
        Double cookieSniperCost = 25000;
        Double cookieNadecost = 100000;
        Double cookieManCost = 250000;
        Double cookieVolcanoCost = 500000;
        Double cookieScienceCost = 1500000;
        Double cookieMineCost = 2000000;
        Double atomCost = 6000000;
        Double urinCost = 10000000;
        Double NUKECOST = 100000000;

        #endregion
        #region count fuctions
        //counts the amount of upgrades you have
        int handAmount = 0;
        int gramaAmount = 0;
        int dogeAmounts = 0;
        int gokuAmount = 0;
        int cookieDrillAmount = 0;
        int newDrillAmount = 0;
        int cookieSniper = 0;
        int cookieNade = 0;
        int cookieMan = 0;
        int cookieVolcano = 0;
        int cookieScience = 0;
        int cookieMine = 0;
        int atom = 0;
        int urin = 0;
        int NUKE = 0;
        int ability = 50;
        #endregion
        public Form1()
        #region cost to strings
        {
            InitializeComponent();
            label1.Text = "cost:" + 100.ToString();
            label4.Text = "cost:" + 300.ToString();
            label5.Text = "cost:" + 500.ToString();
            label11.Text = "cost:" + 2000.ToString();
            label14.Text = "cost:" + 5000.ToString();
            label17.Text = "cost:" + 10000.ToString();
            label21.Text = "cost:" + 25000.ToString();
            label25.Text = "cost:" + 100000.ToString();
            label28.Text = "cost:" + 250000.ToString();
            label31.Text = "cost:" + 500000.ToString();
            label34.Text = "cost:" + 1500000.ToString();
            label37.Text = "cost:" + 2000000.ToString();
            label39.Text = "cost:" + 6000000.ToString();
            label42.Text = "cost:" + 10000000.ToString();
            label46.Text = "cost:" + 120000000.ToString();
        }
        #endregion
        //updates the text box with the total amount of cookies you have
        private void UpdateCookies_Tick(object sender, EventArgs e)
        {
            txt_moneyDisplay.Text = Math.Round(total).ToString();
            totalPassive.Text = Math.Round(passiveIncome).ToString();
        }

        //this adds the passive cookies with the total amount of cookies you have 
        private void PassiveCookies_Tick(object sender, EventArgs e)
        {
            total += (passiveIncome/100);
        }
        #region tooltips
        // this is were i add the hover fuction were when you hover your mouse over you can see what the upgrade is 
        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            // you can change the first parameter (textbox3) on any control you wanna focus
            toolTip1.SetToolTip(pictureBox3, "curser will click for you");
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(pictureBox4, "Just like your own gramma she will bake the best just for you!");
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(pictureBox5, "the doge is a good boy as a treat gram gives him cookies dogs cant eat cookies so he gives them to you!");
        }

        private void pictureBox6_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(pictureBox6, "goku gos super san robbing your competiters for cookies!");
        }

        private void pictureBox7_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(pictureBox7, "old drill used for mining in the cookie mines");
        }

        private void pictureBox8_MouseMove_1(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(pictureBox8, "new drill mines 2x as fast as the old drill, the gigerbread slaves use these to mine in your mines!");
        }

        private void pictureBox9_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(pictureBox9, "the cookie hit man uses this sniper to kill the hits you placed on them!");
        }

        private void pictureBox11_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(pictureBox11, "the cookie gernade exsplodes making lots of cookies ");
        }

        private void pictureBox12_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(pictureBox12, "you took the gigerbread men from lala land and inslaved them to work in your mines");
        }

        private void pictureBox13_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(pictureBox13, "you take a active volcano and inject it with cookies now when it exsplodes and spreads cookies every where!");
        }

        private void pictureBox15_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(pictureBox14, "studying the ways of duplicating cookies, 1 cookie is now worth five(not really)");
        }

        private void pictureBox14_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(pictureBox15, "All the gingerbread men strive to work here it pays well I herd hehehe...");
        }

        private void pictureBox16_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(pictureBox16, "we foound the chemical make up of cookies we now can make nuclure cookies");
        }

        private void pictureBox17_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(pictureBox17, "We can now bake nucluer cookies they exsplode your tast buds (;");
        }

        private void pictureBox18_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(pictureBox18, "it happend we made the bomb the cookie bomb to end all compotition no one will stand in our way again... We win");
        }

        #endregion
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // when cookie is pressed cookiepress is added to the total 
            total += cookiePress;
        }

        //this region holds all the code for upgraded it super long so i hid it lol
        #region upgrade code 

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // if you dont have the money then you get a error message but if you do then the money you have will be subtracted by the cost then +1 will be added 
            // sub is the the subtracting varible

            if (Buy(Upgradesub, 1))
            {
                Upgradesub *= 1.05;
                label1.Text = "cost:" + ((int)Upgradesub).ToString();
                handAmount += 1;
                label7.Text = "# bought: " + handAmount.ToString();


            }
        }
        //cost, and passive are paramiters 
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (Buy(gramCost, 5))
            {
                gramCost *= 1.05;
                label4.Text = "cost:" + ((int)gramCost).ToString();
                gramaAmount += 1;
                label8.Text = "# bought: " + gramaAmount.ToString();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (Buy(dogeCost, 10))
            {
                dogeCost *= 1.05;
                label5.Text = "cost:" + ((int)dogeCost).ToString();
                dogeAmounts += 1;
                label9.Text = "# bought: " + dogeAmounts.ToString();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (Buy(gokuCost, 50))
            {
                gokuCost *= 1.05;
                label11.Text = "cost:" + ((int)gokuCost).ToString();
                gokuAmount += 1;
                label12.Text = "# bought: " + gokuAmount.ToString();
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (Buy(cookieDrillCost, 100))
            {
                cookieDrillCost *= 1.05;
                label14.Text = "cost:" + ((int)cookieDrillCost).ToString();
                cookieDrillAmount += 1;
                label15.Text = "# bought: " + cookieDrillAmount.ToString();
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (Buy(newDirllCost, 500))
            {
                newDirllCost *= 1.15;
                label17.Text = "cost:" + ((int)newDirllCost).ToString();
                newDrillAmount += 1;
                label18.Text = "# bought: " + newDrillAmount.ToString();
            }

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

            if (Buy(cookieSniperCost, 1000))
            {
                cookieSniperCost *= 1.20;
                label21.Text = "cost:" + ((int)cookieSniperCost).ToString();
                cookieSniper += 1;
                label22.Text = "# bought: " + cookieSniper.ToString();
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

            if (Buy(cookieNadecost, 7500))
            {
                cookieNadecost *= 1.25;
                label25.Text = "cost:" + ((int)cookieNadecost).ToString();
                cookieNade += 1;
                label26.Text = "# bought: " + cookieNade.ToString();
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (Buy(cookieManCost, 15000))
            {
                cookieManCost *= 1.30;
                label28.Text = "cost:" + ((int)cookieManCost).ToString();
                cookieMan += 1;
                label29.Text = "# bought: " + cookieMan.ToString();
            }
        }


        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (Buy(cookieVolcanoCost, 30000))
            {
                cookieVolcanoCost *= 1.35;
                label31.Text = "cost:" + ((int)cookieVolcanoCost).ToString();
                cookieVolcano += 1;
                label32.Text = "# bought: " + cookieVolcano.ToString();
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            if (Buy(cookieScienceCost, 60000))
            {
                cookieScienceCost *= 1.40;
                label34.Text = "cost:" + ((int)cookieScienceCost).ToString();
                cookieScience += 1;
                label35.Text = "# bought: " + cookieScience.ToString();
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (Buy(cookieMineCost, 100000))
            {
                cookieMineCost *= 1.45;
                label37.Text = "cost:" + ((int)cookieMineCost).ToString();
                cookieMine += 1;
                label38.Text = "# bought: " + cookieMine.ToString();
            }
        }


        private void pictureBox16_Click(object sender, EventArgs e)
        {
            if (Buy(atomCost, 300000))
            {
                atomCost *= 1.50;
                label39.Text = "cost:" + ((int)atomCost).ToString();
                atom += 1;
                label40.Text = "# bought: " + atom.ToString();
            }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            if (Buy(urinCost, 600000))
            {
                urinCost *= 1.60;
                label42.Text = "cost:" + ((int)urinCost).ToString();
                urin += 1;
                label43.Text = "# bought: " + urin.ToString();
            }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            if (Buy(NUKECOST, 1200000))
            {
                NUKECOST *= 1.60;
                label46.Text = "cost:" + ((int)NUKECOST).ToString();
                NUKE += 1;
                label47.Text = "# bought: " + NUKE.ToString();
            }
        }

        #endregion
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (loadBar.Enabled == false)
            {
                if (progressBar1.Value == 100)
                {
                    progressBar1.Value = 0;
                    ablityTimer.Enabled = true;
                    ability = 0;
                    loadBar.Enabled = true;
                }
            }
        }

        private void ablityTimer_Tick(object sender, EventArgs e)
        {
            if (ability <= 49)
            {
                ability++;
                total += cookiePress;
            }
            else
            {
                ablityTimer.Enabled = false;
            }

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void loadBar_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.PerformStep();
            }
            else
            {
                loadBar.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        //this is where i have the code for my name
        //i use a emty verible to hold what they input then i output is if they say cancle then they can pick a new one
        {
            string name = "";
            name = bakeryName_txt.Text;
            label23.Text = name + ":bakery";
            DialogResult result = MessageBox.Show("are you shure you like the name?", "like your name?", MessageBoxButtons.OKCancel);

            if (name == bakeryName_txt.Text)
            {
                if (result == DialogResult.OK)
                {
                    button1.Visible = false;
                    bakeryName_txt.Visible = false;
                }
                else if (result == DialogResult.Cancel)
                {
                    button1.Visible = true;
                    bakeryName_txt.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("please enter a name", "enter name", MessageBoxButtons.OK);
            }
        }

        #region power ups
        // this is my methed to make my powerup short and not look like the mess that was upgrades
        private bool PowerUp(int Cost, Double percent, int lablecost, Label label, PictureBox pictureBox, double originalchange)
        {
            if (Cost <= total)
            {
                total -= Cost;
                originalchange *= percent;
                passiveIncome += originalchange;
                label.Text = "Power: +" + lablecost.ToString();
                pictureBox.Visible = false;
                return true;
            }
            else
            {
                MessageBox.Show("you dont have enough money nerd", "brokie", MessageBoxButtons.OK);
                return false;
            }

        }
        #region mouse power ups
        private void pictureBox19_Click(object sender, EventArgs e)
        {
            PowerUp(500, 2, 2, label2, pictureBox19, 1);

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            PowerUp(750, 4, 4, label2, pictureBox20, 1);
        }

        #endregion
        #endregion


    }
}
