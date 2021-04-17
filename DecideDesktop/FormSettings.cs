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
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void labelTopUp_Click(object sender, EventArgs e)
        {
            labelTopUp.Text = "";
        }

        private void labelTopUp_MouseLeave(object sender, EventArgs e)
        {
            labelTopUp.ForeColor = Color.White;
        }

        private void labelTopUp_MouseMove(object sender, MouseEventArgs e)
        {
            labelTopUp.ForeColor = Color.FromArgb(215, 179, 6);
        }
    }
}
