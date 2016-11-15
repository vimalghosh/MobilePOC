/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:SanManuelMobile.Core"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using SanManuelMoby.ViewModel;

namespace SanManuelMobile.Core.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<LoginViewModel>();
            SimpleIoc.Default.Register<NovatusViewModel>();
            SimpleIoc.Default.Register<NovatusDetailViewModel>();
            SimpleIoc.Default.Register<LawsonViewModel>();
          
        }

        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

        public LoginViewModel Login
        {
            get
            {
                return ServiceLocator.Current.GetInstance<LoginViewModel>();
            }
        }


        public SignUpViewModel SignUp
        {
            get
            {
                return ServiceLocator.Current.GetInstance<SignUpViewModel>();
            }
        }

        public NovatusViewModel NovatusList
        {
            get
            {
                return ServiceLocator.Current.GetInstance<NovatusViewModel>();
            }
        }

        public NovatusDetailViewModel NovatusDetail
        {
            get
            {
                return ServiceLocator.Current.GetInstance<NovatusDetailViewModel>();
            }
        }

        public LawsonViewModel LawsonList
        {
            get
            {
                return ServiceLocator.Current.GetInstance<LawsonViewModel>();
            }
        }

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }

        public string LoginPage           = "LoginPage";
        public string MainPage            = "MainPage";
        public string SignUpPage          = "SignUpPage";
        public string LawsonListPage      = "LawsonListPage";
        public string LawsonDetailPage    = "LawsonDetailPage";
        public string NovatusListPage     = "NovatusListPage";
        public string NovatusDetailPage   = "NovatusDetailPage";

    }
}