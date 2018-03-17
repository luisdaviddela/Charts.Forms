using OxyPlot;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.Text;

namespace Charts.Forms_Demo
{
    public class Oxyplot_Data
    {
        public PlotModel PieModel { get; set; }
        public PlotModel AreaModel { get; set; }
        public PlotModel CreatePieChart()
        {
            var model = new PlotModel { Title = "World population by continent" };

            var ps = new PieSeries
            {
                StrokeThickness = .25,
                InsideLabelPosition = .25,
                AngleSpan = 360,
                StartAngle = 0
            };

            // http://www.nationsonline.org/oneworld/world_population.htm
            // http://en.wikipedia.org/wiki/Continent
            ps.Slices.Add(new PieSlice("Africa", 1030) { IsExploded = false });
            ps.Slices.Add(new PieSlice("Americas", 929) { IsExploded = false });
            ps.Slices.Add(new PieSlice("Asia", 4157));
            ps.Slices.Add(new PieSlice("Europe", 739) { IsExploded = false });
            ps.Slices.Add(new PieSlice("Oceania", 35) { IsExploded = false });
            model.Series.Add(ps);
            return model;
        }
        public PlotModel CreateArea()
        {
            var model = new PlotModel
            {
                Title = "AreaSeries",
                Subtitle = "Demo "
            };
            var series = new TwoColorAreaSeries { Title = "series" };
            var series2 = new TwoColorAreaSeries { Title = "series" };
            for (double x = 1; x <= 10; x++)
            {
                series.Points.Add(new DataPoint(x, (-1 * (x * x) + 50)));
                //series.Points2.Add(new DataPoint(x, x));
            }
            for (double x = -10; x <= 10; x++)
            {
                series2.Points.Add(new DataPoint(x, (-1 * (x * x) + 60)));
                series.Points2.Add(new DataPoint(x, x));
            }
            series.Color2 = OxyColors.Transparent;
            series2.Color2 = OxyColors.Transparent;
            model.Series.Add(series);
            //model.Series.Add(series2);
            return model;
        }
    }
}
