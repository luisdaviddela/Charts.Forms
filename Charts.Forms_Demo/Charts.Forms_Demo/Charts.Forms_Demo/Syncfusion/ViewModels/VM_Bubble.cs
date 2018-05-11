using Syncfusion.SfChart.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Charts.Forms_Demo
{
    class VM_Bubble
    {

        public ObservableCollection<ChartDataPoint> Data { get; set; }
        public VM_Bubble()
        {
            Data = new ObservableCollection<ChartDataPoint>
            {
                new ChartDataPoint(1,3,3),
                new ChartDataPoint(1,3.5,3),
                new ChartDataPoint(1,2.99,3),
                new ChartDataPoint(1,4,3)
            };
        }
    }
}
