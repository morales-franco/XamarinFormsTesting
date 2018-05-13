using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloWorld
{
	public partial class MainPage : ContentPage
	{
        List<string> textList = new List<string>()
        {
            "Texto 1",
            "Texto 2",
            "Texto 3"
        };

		public MainPage()
		{
			InitializeComponent();
            slider.Value = 0.5;
            sliderFontSize.Value = 16;
            textVariable.Text = textList.First();

        }

        void Handle_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            label.Text = string.Format("Slider Value is {0:F2}", e.NewValue);
        }

        void Handle_Clicked_ChangeText(object sender, EventArgs e)
        {
            var currentText = textVariable.Text;
            var currentPosition = textList.IndexOf(currentText);

            if (currentPosition == 2)
                textVariable.Text = textList[0];
            else
                textVariable.Text = textList[currentPosition + 1];

        }


    }
}
