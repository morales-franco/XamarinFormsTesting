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
	public partial class ImagePage : ContentPage
	{
		public ImagePage ()
		{
			InitializeComponent ();

            var imageSource = new UriImageSource() {
                Uri = new Uri("https://cdn.britannica.com/700x450/25/180825-004-F51CFBFE.jpg"),
                CachingEnabled = false
            };

            image.Source = imageSource;



		}
	}
}