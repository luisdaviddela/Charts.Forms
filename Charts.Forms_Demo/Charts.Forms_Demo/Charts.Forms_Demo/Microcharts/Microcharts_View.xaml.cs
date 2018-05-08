using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microcharts;

namespace Charts.Forms_Demo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Microcharts_View : ContentPage
	{
        Microcharts_Data data = new Microcharts_Data();
        public Microcharts_View ()
		{
			InitializeComponent ();
            Chartedemo.Chart = new LineChart { Entries = data.GetChart() };
            Chartedemo1.Chart = new DonutChart { Entries = data.GetChart() };
            Chartedemo2.Chart = new PieChart { Entries = data.GetChart() };
            Chartedemo3.Chart = new PointChart { Entries = data.GetChart() };
            Chartedemo4.Chart = new RadarChart { Entries = data.GetChart() };
            Chartedemo5.Chart = new RadialGaugeChart { Entries = data.GetChart() };
            Chartedemo6.Chart = new BarChart { Entries = data.GetChart() };
        }
	}
}