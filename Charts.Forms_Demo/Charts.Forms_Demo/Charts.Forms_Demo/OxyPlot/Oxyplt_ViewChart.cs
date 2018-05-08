﻿using OxyPlot.Xamarin.Forms;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Charts.Forms_Demo
{
    public class Oxyplt_ViewChart :ContentPage
    {
        Oxyplot_Data data = new Oxyplot_Data();
        public Oxyplt_ViewChart()
        {
            Content = new PlotView
            {
                //Model = data.CreateArea(),
               Model = data.CreatePieChart(),
                VerticalOptions = LayoutOptions.Fill,
                HorizontalOptions = LayoutOptions.Fill,
            };

        }
    }
}
