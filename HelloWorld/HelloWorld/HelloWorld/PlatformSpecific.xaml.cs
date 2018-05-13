using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    /*
     * Imagenes especificas según plataforma
     * IOS:
     * clock.png (32x32)
     * clock@2x.png (64x64)
     * clock@3x.png (96x96)
     * 
     * ANDROID
     * drawable 32x32
     * drawable-hdpi 48x48
     * drawable-xhdpi 64x64
     * drawable-xxhdpi 96x96
     */
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PlatformSpecific : ContentPage
	{
		public PlatformSpecific ()
		{
			InitializeComponent ();
            btn.Image = GetImageSource();
		}

        private FileImageSource GetImageSource()
        {
            string source = string.Empty;

            switch (Device.RuntimePlatform)
            {
                case Device.Android:
                    source = "mobileSO.png";
                    break;
                case Device.iOS:
                    source = "mobileSO.png";
                    break;
                case Device.UWP:
                default:
                    break;
            }

            return (FileImageSource)ImageSource.FromFile(source);
        }
    }
}