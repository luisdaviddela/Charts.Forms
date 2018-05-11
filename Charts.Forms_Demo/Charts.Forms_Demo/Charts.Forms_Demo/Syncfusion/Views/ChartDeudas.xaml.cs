using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Charts.Forms_Demo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ChartDeudas : ContentPage
	{
		public ChartDeudas ()
		{
			InitializeComponent ();
            BindingContext = new VM_Deudas();
		}
	}
}