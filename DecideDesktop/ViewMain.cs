using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecideDesktop
{
    public partial class ViewMain : Form
    {
        
        public ViewMain()
        {
            InitializeComponent();
            CustomizeDesign();
        }
        internal void CustomizeDesign()
        {
            panelMenuSubmenu.Visible = false;
            panelCurrencySubmenu.Visible = false;
        }
        internal void hideSubMenu()
        {
            if (panelMenuSubmenu.Visible == true)
                panelMenuSubmenu.Visible = false;
            if (panelCurrencySubmenu.Visible == true)
                panelCurrencySubmenu.Visible = false;
        }
        internal void showSubMenu(Panel SubMenu)
        {
            if(SubMenu.Visible==false)
            {
                //hideSubMenu();
                SubMenu.Visible = true;

            }
            else
            {
                SubMenu.Visible = false;
            }
        }

        private void btmMenu_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMenuSubmenu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //
            //
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            //
            //
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            //
            //
            hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            //
            //
            hideSubMenu();
        }
        
        private void btnCurrency_Click(object sender, EventArgs e)
        {
            showSubMenu(panelCurrencySubmenu);
        }

        private void button5_Click(object sender, EventArgs e)
        {

            //
            //
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            //
            //
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            //
            //
            hideSubMenu();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btmMenu_MouseMove(object sender, MouseEventArgs e)
        {
            btmMenu.ForeColor = Color.FromArgb(215, 179, 6);

        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.ForeColor = Color.FromArgb(215, 179, 6);
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.ForeColor = Color.FromArgb(215, 179, 6);
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            button4.ForeColor = Color.FromArgb(215, 179, 6);
        }

        private void button8_MouseMove(object sender, MouseEventArgs e)
        {
            button8.ForeColor = Color.FromArgb(215, 179, 6);
        }

        private void btnCurrency_MouseMove(object sender, MouseEventArgs e)
        {
            btnCurrency.ForeColor = Color.FromArgb(215, 179, 6);
        }

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            button5.ForeColor = Color.FromArgb(215, 179, 6);
        }

        private void button6_MouseMove(object sender, MouseEventArgs e)
        {
            button6.ForeColor = Color.FromArgb(215, 179, 6);
        }

        private void button7_MouseMove(object sender, MouseEventArgs e)
        {
            button7.ForeColor = Color.FromArgb(215, 179, 6);
        }

        private void btmMenu_MouseLeave(object sender, EventArgs e)
        {
            btmMenu.ForeColor = Color.White;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.White;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.White;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.ForeColor = Color.White;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.ForeColor = Color.White;
        }

        private void btnCurrency_MouseLeave(object sender, EventArgs e)
        {
            btnCurrency.ForeColor = Color.White;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.ForeColor = Color.White;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.ForeColor = Color.White;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.ForeColor = Color.White;
        }

        private void picExit_MouseMove(object sender, MouseEventArgs e)
        {
            picExit.BackgroundImage = Properties.Resources.exit_yellow;
        }

        private void picExit_MouseLeave(object sender, EventArgs e)
        {
            picExit.BackgroundImage = Properties.Resources.exit_grey;
        }

        private void ViewMain_Load(object sender, EventArgs e)
        {
            
        }
    }
}
