using HelloWorld.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListContextAcions : ContentPage
	{
        //Para notificar a listView cuando se eliminen los contactos
        //Esto hace que cuando se modifica la lista fire a event, lanza un evento
        //Si usamos list, se actualizara la lista en memoria pero NO lo reflejara el ListView en la pantalla
        private ObservableCollection<Contact> _contacts = new ObservableCollection<Contact>();

		public ListContextAcions ()
		{
			InitializeComponent ();
            _contacts = GetAllContact();

            listView.ItemsSource = _contacts;
        }

        private void Call_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;
            DisplayAlert("Call", contact.Name, "OK");
        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Contact;

            _contacts.Remove(contact);

            DisplayAlert("Delete", contact.Name, "OK");
        }

        private void listView_Refreshing(object sender, EventArgs e)
        {
            _contacts = GetAllContact();
            listView.ItemsSource = _contacts;
            listView.EndRefresh();
        }

        private ObservableCollection<Contact> GetAllContact()
        {
            return new ObservableCollection<Contact>()
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
    }
}