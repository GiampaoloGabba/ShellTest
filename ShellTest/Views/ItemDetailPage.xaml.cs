using System.ComponentModel;
using Xamarin.Forms;
using ShellTest.ViewModels;

namespace ShellTest.Views
{
	public partial class ItemDetailPage : ContentPage
	{
		public ItemDetailPage()
		{
			InitializeComponent();
			BindingContext = new ItemDetailViewModel();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			var navStack = ((ShellGroupItem) Parent).Navigation.NavigationStack;
			var output   = "";

			for (int i = 0; i < navStack.Count; i++)
			{
				output += $"Index {i}, page: {navStack[i]?.ToString() ?? "null"} {System.Environment.NewLine}";
			}

			OutputLabel.Text = output;

		}
	}
}
