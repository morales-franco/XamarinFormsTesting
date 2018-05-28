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
	public partial class ContactDetailPageEj : ContentPage
	{
        public event EventHandler<ContactEj> ContactAdded;
        public event EventHandler<ContactEj> ContactUpdate;

        public ContactDetailPageEj (ContactEj contact)
		{
            if (contact == null)
                contact = new ContactEj();

            /*
             * Instanciamos un objeto nuevo, y no le pasamos contact directamente al BindingContext
             * porque sino al modificar propiedades en la vista, se va a modificar contact, ya que se 
             * pasa por referencia.
             * Entonces haga click en save o no, se guardarian los cambios.
             */
            BindingContext = new ContactEj() {
                Id = contact.Id,
                Blocked = contact.Blocked,
                Email = contact.Email,
                FirstName = contact.FirstName,
                LastName = contact.LastName,
                Phone = contact.Phone
            };

            InitializeComponent ();
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var contact = BindingContext as ContactEj;

            if (String.IsNullOrWhiteSpace(contact.FirstName))
            {
                await DisplayAlert("Error", "Por favor ingrese el nombre.", "OK");
                return;
            }

            if (contact.Id > 0)
                ContactUpdate.Invoke(this, contact);
            else
                ContactAdded.Invoke(this, contact);
        }
    }
}