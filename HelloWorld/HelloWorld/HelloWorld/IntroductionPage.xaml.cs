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
	public partial class IntroductionPage : ContentPage
	{
		public IntroductionPage ()
		{
			InitializeComponent ();
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
            //Navigation.PopModalAsync() For modal
        }

        protected override bool OnBackButtonPressed()
        {
            //return true; no retorna a pagina anterior al apretar el botón volver del smartphone
            return base.OnBackButtonPressed();
        }
    }
}