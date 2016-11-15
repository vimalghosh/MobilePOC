using SanManuelMobile.Core.Models;
using SanManuelMobile.Core.ViewModel;
using SanManuelMoble.Core.Contracts.ViewModel;
using System;
using Xamarin.Forms;

namespace SanManuelMobile.Core.Views
{
    public partial class LoginPage : ContentPage
    {
        LoginViewModel loginvm;
        public LoginPage()
        {
            InitializeComponent();
            loginvm = App.Locator.Login;
            BindingContext = loginvm;
            
        }

     
    }
}
