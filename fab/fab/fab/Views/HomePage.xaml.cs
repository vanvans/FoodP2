using System;
using System.Collections.Generic;
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
            List<Timeline> timelines = await AzureManager.AzureManagerInstance.GetTimelines();
            FakedataList.ItemsSource = timelines;

        }

    }
}
