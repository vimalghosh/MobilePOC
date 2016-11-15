using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SanManuelMobile.Core.ViewModel
{
    public class MainViewModel : ViewModelBase
    {

        private INavigationService mainNavigation;


        public RelayCommand LogoutCommand { get; set; }
        public RelayCommand LawsonCommand { get; set; }
        public RelayCommand NevotusCommand { get; set; }
        public MainViewModel(INavigationService nav)
        {
            mainNavigation = nav;
            LogoutCommand = new RelayCommand(() =>
            {
                App.IsUserLoggedIn = false;
                mainNavigation.NavigateTo(App.Locator.LoginPage);
            });
            LawsonCommand = new RelayCommand(() =>
            {
                mainNavigation.NavigateTo(App.Locator.LawsonListPage);
            });

            NevotusCommand = new RelayCommand(() =>
            {
                mainNavigation.NavigateTo(App.Locator.NovatusListPage);
            });
        }

    }

}
