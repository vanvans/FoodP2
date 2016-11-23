using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Linq;
using System.Text;
using System.Reflection.Emit;
using Moodify.DataModels;

namespace Moodify
{
    public partial class HomePage : ContentPage
	{
		public HomePage()
		{
			InitializeComponent();
		}




        private async void LoginWithFacebook_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SecondPage());
        }

	}

}
