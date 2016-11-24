using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fab.DataModels;
using Xamarin.Forms;

namespace fab
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }


        private async void ViewFakedata_Clicked(Object sender, EventArgs e)
        {
            List<Fakedata> fakedatas = await AzureManager.AzureManagerInstance.GetFakedatas();
            FakedataList.ItemsSource = fakedatas;
        }

    }
}
