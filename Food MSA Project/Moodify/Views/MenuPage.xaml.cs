using System;
using System.Collections.Generic;
using Microsoft.WindowsAzure.MobileServices;
using Xamarin.Forms;

namespace Moodify
{
	public partial class MenuPage : ContentPage
	{
		public MenuPage()
		{
			BindingContext = new MenuPageViewModel();
			Title = "Menu";
            Icon = Device.OS == TargetPlatform.iOS ? "menu.png" : null;
            InitializeComponent();
		}
	}
}
