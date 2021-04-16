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
        public static List<float> GraphicData = new List<float>();
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            DrawGraphic(ViewMain.BTCGraphic);
        }
        public static  void DrawGraphic(List<float> GraphicData)
        {
            SeriesCollection series = new SeriesCollection();
            ChartValues<int> ContValues = new ChartValues<int>();
            DateTime dateTime = DateTime.Now;

            List<string> dates = new List<string>();
            for (int i = GraphicData.Count; i > 0; i--)
            {
                dates.Add(i + "");
            }
            int b = GraphicData.Count;
            for (int i = 0; i < GraphicData.Count; i++)
            {
                ContValues.Add((int)GraphicData[i]);
            }
            Graphic.AxisX.Clear();

            Graphic.AxisX.Add(new Axis()
            {
                Title = "Time",
                Labels = dates,

            });

            LineSeries line = new LineSeries();

            line.Title = "";
            line.Values = ContValues;
            var converter = new System.Windows.Media.BrushConverter();
            var Brush = converter.ConvertFromString("#FFF2A7");
            line.Foreground = Brush as System.Windows.Media.Brush;

            series.Add(line);

            Graphic.Series = series;
        }
       

        private void btnlive_Click(object sender, EventArgs e)
        {

        }

        private void btn15min_Click(object sender, EventArgs e)
        {

        }

        private void btn1hour_Click(object sender, EventArgs e)
        {

        }

        private void btn1day_Click(object sender, EventArgs e)
        {

        }
    }
}
