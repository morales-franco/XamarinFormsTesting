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
	public partial class ContactMethodListPage : ContentPage
	{
		public ContactMethodListPage ()
		{
			InitializeComponent ();
            listView.ItemsSource = new List<string> {
                "None",
                "Email",
                "SMS"
            };
        }

        public ListView ContactMethods { get { return listView; } }
    }
}