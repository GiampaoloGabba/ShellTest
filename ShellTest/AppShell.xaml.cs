using System;
using System.Collections.Generic;
using ShellTest.ViewModels;
using ShellTest.Views;
using Xamarin.Forms;

namespace ShellTest
{
	public partial class AppShell : Xamarin.Forms.Shell
	{
		public AppShell()
		{
			InitializeComponent();
			Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
		}

	}
}
