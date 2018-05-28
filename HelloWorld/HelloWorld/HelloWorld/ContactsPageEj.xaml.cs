using HelloWorld.Models;
using System;
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
	public partial class ContactsPageEj : ContentPage
	{
        ObservableCollection<ContactEj> _Contacts;

		public ContactsPageEj ()
		{
			InitializeComponent ();
            _Contacts = new ObservableCollection<ContactEj>();
            listView.ItemsSource = _Contacts;
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            var page = new ContactDetailPageEj(null);

            page.ContactAdded += (source, contact) =>
            {
                contact.Id = _Contacts.Count + 1;
                _Contacts.Add(contact);
                Navigation.PopAsync();
            };

            Navigation.PushAsync(page);
        }

        private void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var contactSelected = e.Item as ContactEj;
            var page = new ContactDetailPageEj(contactSelected);
            listView.SelectedItem = null;

            page.ContactUpdate += (source, contact) =>
            {
                var oldContact = _Contacts.FirstOrDefault(c => c.Id == contact.Id);
                oldContact.FirstName = contact.FirstName;
                oldContact.LastName = contact.LastName;
                oldContact.Blocked = contact.Blocked;
                oldContact.Email = contact.Email;
                oldContact.Phone = contact.Phone;
                Navigation.PopAsync();
            };

            Navigation.PushAsync(page);
        }

        private async void MenuItem_Clicked(object sender, EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as ContactEj;

            if (await DisplayAlert("Advertencia", $"Esta seguro que desea eliminar a {contact.FirstName}?", "Si", "No"))
            {
                _Contacts.Remove(contact);
                await DisplayAlert("Exito", $"{contact.FirstName} ha sido eliminado exitosamente", "OK");
            }
               
        }
    }
}