using Syncfusion.SfChart.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
namespace Charts.Forms_Demo
{
    public class DOnutPrueba : NavigationPage
    {
        public ObservableCollection<ChartDataPoint> DataPoints;
        ContentPage contentPage;
        public DOnutPrueba()
        {
            this.Title = "DOnut Chart";
            contentPage = new ContentPage();
            DataPoints = new ObservableCollection<ChartDataPoint>();

            DataPoints.Add(new ChartDataPoint("Jan", 20));
            DataPoints.Add(new ChartDataPoint("Feb", 25));
            DataPoints.Add(new ChartDataPoint("Mar", 30));
            DataPoints.Add(new ChartDataPoint("Apr", 28));
            DataPoints.Add(new ChartDataPoint("May", 15));
            DataPoints.Add(new ChartDataPoint("Jun", 20));

            SfChart chart = new SfChart();
            chart.Title.Text = "PieChart";

            PieSeries pieSeries = new PieSeries();
            pieSeries.EnableDataPointSelection = true;
            pieSeries.ItemsSource = DataPoints;
            chart.Series.Add(pieSeries);
            chart.SelectionChanged += Chart_SelectionChanged;

            contentPage.Content = chart;

            Navigation.PushAsync(contentPage, false);
        }
        private void Chart_SelectionChanged(object sender, ChartSelectionEventArgs e)
        {
            Navigation.PushAsync(new ContentPage()
            {
                Content = new Label()
                {
                    FontSize = 20,
                    TextColor = Color.Purple,
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                    Text = "You have Selected an index No: " + e.SelectedDataPointIndex,
                }
            }, false);
        }
    }
}
