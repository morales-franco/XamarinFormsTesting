using HelloWorld.Models;
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
	public partial class ListSelections : ContentPage
	{
		public ListSelections ()
		{
			InitializeComponent ();
            listView.ItemsSource = new List<Contact>()
            {
                new Contact()
                {
                    Name = "Franco",
                    Status = "Hey, Let's talk!",
                    ImageUrl= "https://scontent.faep12-1.fna.fbcdn.net/v/t1.0-9/11045420_10204942993867743_4130686495764651941_n.jpg?_nc_cat=0&oh=e522765137323d377e99215e14c5748a&oe=5B852D1F",
                },
                new Contact()
                {
                    Name = "Pau",
                    Status = "Hey, Let's go to NZ!",
                    ImageUrl= "https://scontent.faep12-1.fna.fbcdn.net/v/t1.0-9/29177705_10156197407696460_6310215041238109629_n.jpg?_nc_cat=0&oh=d960c0f98489942faf08b690d28b7d3c&oe=5B9A490A",
                },
                new Contact()
                {
                    Name = "Air NZ",
                    Status = "Hey, Let's travel with me!",
                    ImageUrl= "http://www.airlinereporter.com/wp-content/uploads/2013/11/4.jpg",
                }
            };
        }

        /*
         * Selected: cuando seleccionas por primera vez una celda
         * Tapped: cuando clickeas sobre una celda independientemente si estaba seleccionada o no
         * 
         * Si anulamos el evento Selected solo salta el Tapped
         */

        private void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            //listView.SelectedItem = null; Anula selección

            var contactTapped = e.Item as Contact;
            DisplayAlert("Tapped", contactTapped.Name, "OK");
        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //e information about selected item

            var contactSelectd = e.SelectedItem as Contact;
            DisplayAlert("Selected", contactSelectd.Name, "OK");
        }
    }
}