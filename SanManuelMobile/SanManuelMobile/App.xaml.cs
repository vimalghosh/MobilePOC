using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using Microsoft.Practices.ServiceLocation;
using SanManuelMobile.Core.Contracts.Services;
using SanManuelMobile.Core.Services;
using SanManuelMobile.Core.Views;
using SanManuelMobile.Core.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace SanManuelMobile.Core
{
    public partial class App : Application
    {
        private static ViewModelLocator _locator;
        public static bool IsUserLoggedIn { get; set; }

        public static string UserName { get; set; }
        public static ViewModelLocator Locator
        {
            get
            {
                return _locator ?? (_locator = new ViewModelLocator());
            }
        }


        public static NavigationPage GetStartPage()
        {
            if (!IsUserLoggedIn)
            {
                return  new NavigationPage(new LoginPage());
            }
            else
            {
                return new NavigationPage(new MainPage());
            }
        }

        public App()
        {
            InitializeComponent();

            //Registering the Service
            var nav = new NavigationService();
            SimpleIoc.Default.Register<ILoginService,LoginService>();
            SimpleIoc.Default.Register<INovatusService, NovatusService>();
            SimpleIoc.Default.Register<NovatusDetail>();

            //Registering the Navigation
            nav.Configure(Locator.MainPage, typeof(MainPage));
            nav.Configure(Locator.LoginPage, typeof(LoginPage));
            nav.Configure(Locator.SignUpPage, typeof(SignUpPage));
            nav.Configure(Locator.LawsonListPage, typeof(LawsonListPage));
            nav.Configure(Locator.NovatusListPage, typeof(NovotusListPage));
            nav.Configure(Locator.NovatusDetailPage, typeof(NovatusDetail));

            SimpleIoc.Default.Register<INavigationService>(() => nav);

            var startPage = GetStartPage();
            nav.Initialize(startPage);
            MainPage = startPage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
