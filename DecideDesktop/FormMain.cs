using DecideDesktop.Classes;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
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
    public partial class FormMain : Form
    {
        internal static GraphicSystem FormMainGraphic;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            ViewMain.FormMain = this;
            FormMainGraphic = new GraphicSystem(Graphic);
        }

        private void btnlive_Click(object sender, EventArgs e)
        {

        }

        private void btn15min_Click(object sender, EventArgs e)
        {
            FormMainGraphic.GraphicsDraw(ViewMain.BTCGraphic15m, "15m");
        }

        private void btn1hour_Click(object sender, EventArgs e)
        {
            FormMainGraphic.GraphicsDraw(ViewMain.BTCGraphic1h);
        }

        private void btn1day_Click(object sender, EventArgs e)
        {
            FormMainGraphic.GraphicsDraw(ViewMain.BTCGraphic1d, "1d");
        }
    }
}
