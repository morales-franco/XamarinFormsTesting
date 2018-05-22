using HelloWorld.Models;
using HelloWorld.Services;
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
	public partial class Instagram_Detail : ContentPage
	{
		public Instagram_Detail (Models.Activity activity)
		{
			InitializeComponent ();

            if(activity == null)
                throw new ArgumentNullException();

            UserService userService = new UserService();
            User user = userService.GetUser(activity.UserId);

            BindingContext = user;
        }
	}
}