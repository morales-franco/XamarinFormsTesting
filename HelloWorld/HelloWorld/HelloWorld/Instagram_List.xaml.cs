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
	public partial class Instagram_List : ContentPage
	{
		public Instagram_List ()
		{
			InitializeComponent ();
            var activityService = new ActivityService();
            listView.ItemsSource = activityService.GetActivities();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            
            if (e.SelectedItem == null)
                return;

            var activity = e.SelectedItem as Activity;

            listView.SelectedItem = null;

            await Navigation.PushAsync(new Instagram_Detail(activity));
        }
    }
}