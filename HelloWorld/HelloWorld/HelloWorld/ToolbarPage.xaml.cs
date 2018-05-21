using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ToolbarPage : ContentPage
	{
		public ToolbarPage ()
		{
			InitializeComponent ();
		}

        private async void ToolbarItem_Activated(object sender, EventArgs e)
        {
            await DisplayAlert("Activated", "ToolbarItem Activated", "OK");
        }
    }
}