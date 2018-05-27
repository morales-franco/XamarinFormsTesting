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
	public partial class PickersFormPage : ContentPage
	{
        IList<ContactMethod> _contactMethods;

		public PickersFormPage ()
		{
			InitializeComponent ();
            _contactMethods = GetAllContactMethods();

            foreach (var contact in _contactMethods)
            {
                contactMethods.Items.Add(contact.Description);
            }
		}

        private void contactMethods_SelectedIndexChanged(object sender, EventArgs e)
        {
            var contactName = contactMethods.Items[contactMethods.SelectedIndex];
            var contact = _contactMethods.FirstOrDefault(c => c.Description == contactName);

            DisplayAlert("Selection", contact.Description, "Ok");
        }

        private IList<ContactMethod>  GetAllContactMethods()
        {
            return new List<ContactMethod> {
                new ContactMethod()
                {
                    ContactMethodId=1,
                    Description="SMS"
                },
                new ContactMethod()
                {
                    ContactMethodId=2,
                    Description = "Email"
                }
            };
        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {

        }
    }
}