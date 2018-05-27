using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace HelloWorld
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            //MainPage = new HelloWorld.MainPage();
            //MainPage = new StackPage();
            //MainPage = new StackPageEjLogin();
            //MainPage = new StackPageEj2();
            //MainPage = new GridPage();
            //MainPage = new GridPageEj1();
            //MainPage = new GridPageEj2();
            //MainPage = new AbsolutePage();
            //MainPage = new AbsolutePageEj1();
            //MainPage = new AbsolutePageEj2();
            //MainPage = new ImagePage();
            //MainPage = new EmbeddedImage();
            //MainPage = new PlatformSpecific();
            //MainPage = new ImageCircle();
            //MainPage = new ImageExercise();
            //MainPage = new List1();
            //MainPage = new ListGroup();
            //MainPage = new ListSelections();
            //MainPage = new ListContextAcions();
            //MainPage = new ListSearchBar();

            //MainPage = new NavigationPage(new WelcomePage())
            //{
            //    BarBackgroundColor = Color.Gray,
            //    BarTextColor = Color.White
            //};

            //MainPage = new NavigationPage(new ContactsPage());

            //MainPage = new MasterContactsPage();

            //MainPage = new TabbedPage1();

            //MainPage = new CarouselPage1();

            //MainPage = new PopUpPage();

            //MainPage = new NavigationPage(new ToolbarPage());

            // MainPage = new NavigationPage(new Instagram_Tab());

            //MainPage = new FormItemsPage();

            //MainPage = new PickersFormPage();

            // MainPage = new TableViewPage();

            MainPage = new NavigationPage(new TableViewPage());
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
