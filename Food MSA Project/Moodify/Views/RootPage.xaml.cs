using System;
using System.Collections.Generic;
using Microsoft.WindowsAzure.MobileServices;
using Xamarin.Forms;

namespace Moodify
{
	public partial class RootPage : MasterDetailPage
	{
		public RootPage()
		{
			InitializeComponent();
			MasterBehavior = MasterBehavior.Popover;
		}
	}
}
