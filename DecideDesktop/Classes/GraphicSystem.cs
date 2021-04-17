using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecideDesktop.Classes
{
    class GraphicSystem
    {
        internal LiveCharts.WinForms.CartesianChart Graphic { get; set; }

        public GraphicSystem(LiveCharts.WinForms.CartesianChart Graphic)
        {
            this.Graphic = Graphic;
        }
        public GraphicSystem() { }

        internal void GraphicsDraw(List<float> GraphicsData, string interval = "1h")
        {
            SeriesCollection series = new SeriesCollection();
            ChartValues<float> ContValues = new ChartValues<float>();
            List<Int64> dates = new List<Int64>();
            List<string> Times = new List<string>();
            DateTime nowTime = DateTime.Now;
            var unixNowTime = ((DateTimeOffset)nowTime).ToUnixTimeSeconds();
            dates.Add(unixNowTime);

            switch (interval)
            {
                case "1h":
                    {
                        for (int i = 0; i < GraphicsData.Count + 1; i++)
                        {
                            dates.Add(dates[i] - 3600);
                        }

                        for (int i = GraphicsData.Count - 1; i >= 0; i--)
                        {
                            Times.Add(ConvertFromUnixTimestamp(dates[0] - i * 3600).ToString());
                        }
                        for (int i = 0; i < GraphicsData.Count; i++)
                        {
                            ContValues.Add((float)GraphicsData[i]);
                        }

                        Graphic.AxisX.Clear();

                        Graphic.AxisX.Add(new Axis()
                        {
                            Title = "Time",
                            Labels = Times,
                        });

                        LineSeries line = new LineSeries();

                        line.Title = "";
                        line.Values = ContValues;
                        var converter = new System.Windows.Media.BrushConverter();
                        var Brush = converter.ConvertFromString("#FFF2A7");
                        line.Foreground = Brush as System.Windows.Media.Brush;

                        series.Add(line);

                        Graphic.Series = series;
                        break;
                    }
                case "15m":
                    {
                        for (int i = 0; i < GraphicsData.Count + 1; i++)
                        {
                            dates.Add(dates[i] - 900);
                        }

                        for (int i = GraphicsData.Count - 1; i >= 0; i--)
                        {
                            Times.Add(ConvertFromUnixTimestamp(dates[0] - i * 900).ToString());
                        }
                        for (int i = 0; i < GraphicsData.Count; i++)
                        {
                            ContValues.Add((float)GraphicsData[i]);
                        }

                        Graphic.AxisX.Clear();

                        Graphic.AxisX.Add(new Axis()
                        {
                            Title = "Time",
                            Labels = Times,
                        });

                        LineSeries line = new LineSeries();

                        line.Title = "";
                        line.Values = ContValues;
                        var converter = new System.Windows.Media.BrushConverter();
                        var Brush = converter.ConvertFromString("#FFF2A7");
                        line.Foreground = Brush as System.Windows.Media.Brush;

                        series.Add(line);

                        Graphic.Series = series;
                        break;
                    }
                case "1d":
                    {
                        for (int i = 0; i < GraphicsData.Count + 1; i++)
                        {
                            dates.Add(dates[i] - 86400);
                        }

                        for (int i = GraphicsData.Count - 1; i >= 0; i--)
                        {
                            Times.Add(ConvertFromUnixTimestamp(dates[0] - i * 86400).ToString());
                        }
                        for (int i = 0; i < GraphicsData.Count; i++)
                        {
                            ContValues.Add((float)GraphicsData[i]);
                        }

                        Graphic.AxisX.Clear();

                        Graphic.AxisX.Add(new Axis()
                        {
                            Title = "Time",
                            Labels = Times,
                        });

                        LineSeries line = new LineSeries();

                        line.Title = "";
                        line.Values = ContValues;
                        var converter = new System.Windows.Media.BrushConverter();
                        var Brush = converter.ConvertFromString("#FFF2A7");
                        line.Foreground = Brush as System.Windows.Media.Brush;

                        series.Add(line);

                        Graphic.Series = series;
                        break;
                    }
            }
        }
  
        static DateTime ConvertFromUnixTimestamp(double timestamp)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return origin.AddSeconds(timestamp);
        }
    }
}
