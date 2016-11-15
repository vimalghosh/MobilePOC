using SanManuelMobile.Core.ViewModel;
using SanManuelMoby.ViewModel;
using System;
using Xamarin.Forms;

namespace SanManuelMobile.Core.Views
{
	public partial class MainPage : ContentPage
	{
        MainViewModel vm;
		public MainPage ()
		{
			InitializeComponent ();
            vm = App.Locator.Main;
            BindingContext = vm;
           // NevotusButton.Image = new FileImageSource { File = "Nevotus.png" };
		}

		//async void OnLogoutButtonClicked (object sender, EventArgs e)
		//{
		//	await App.IsUserLoggedIn = false;
		//	//Navigation.InsertPageBefore (new LoginPage (), this);
		//	//await Navigation.PopAsync ();
		//}
	}
}
