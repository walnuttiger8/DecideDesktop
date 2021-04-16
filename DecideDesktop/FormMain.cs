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
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            SeriesCollection series = new SeriesCollection();
            ChartValues<int> ContValues = new ChartValues<int>();
            DateTime dateTime = DateTime.Now;
            
            List<string> dates = new List<string>();
            for(int i = ViewMain.BTCGraphic.Count; i>0;i--)
            {
                dates.Add(i+"");
            }
            int b = ViewMain.BTCGraphic.Count;
            for(int i = 0;i<ViewMain.BTCGraphic.Count;i++)
            {
                ContValues.Add((int)ViewMain.BTCGraphic[i]);
            }
            BTCGraphic.AxisX.Clear();
             
            BTCGraphic.AxisX.Add(new Axis()
            {
                Title = "Time",
                Labels = dates ,
                
            });
            
            LineSeries line = new LineSeries();
            
            line.Title = "";
            line.Values = ContValues;
            var converter = new System.Windows.Media.BrushConverter();
            var Brush = converter.ConvertFromString("#FFF2A7");
            line.Foreground = Brush as System.Windows.Media.Brush;

            series.Add(line);

            BTCGraphic.Series = series;


        }
    }
}
