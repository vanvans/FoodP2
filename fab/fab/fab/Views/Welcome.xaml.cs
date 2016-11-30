using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Emit;
using Xamarin.Forms;

namespace fab
{
    public partial class Welcome : ContentPage
    {
        public Welcome()
        {
            InitializeComponent();
        }


        public async void guestClick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }



        public async void userClick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }



        async void helpmessage(object sender, EventArgs args)
        {
            Button button = (Button)sender;
            await DisplayAlert("Fabrikam", "We are an innovative food outlet that seeks to provide our customers with a fulfilling and personalized experience. Continue onwards to view our menu and learn more about us.", "OK");
        }

    }
}
