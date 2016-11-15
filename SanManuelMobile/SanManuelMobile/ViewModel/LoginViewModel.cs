using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using SanManuelMobile.Core.Contracts.Services;
using SanManuelMobile.Core.Models;
using SanManuelMobile.Core.Services;
using SanManuelMoble.Core.Contracts.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SanManuelMobile.Core.Utility;


namespace SanManuelMobile.Core.ViewModel
{
    public class LoginViewModel: BaseViewModel,ILoginViewModel
    {
        ILoginService loginservice;
        INavigationService mainNavigtion;
        public AsyncRelayCommand UserLoginCommand { get; private set; }
        public RelayCommand SignUpCommand { get; private set; }
        public RelayCommand CancelCommand { get; private set; }



        public LoginViewModel(ILoginService service, INavigationService nav)
        {
            mainNavigtion = nav;
            loginservice = service;

            UserLoginCommand = new AsyncRelayCommand(LoginButtonClicked);
            SignUpCommand = new RelayCommand(() => SignUpButtonClicked());
            CancelCommand = new RelayCommand(() => CancelButtonClicked());
        }

        private void CancelButtonClicked()
        {
            Username = "";
            Password = "";

        }
        void LoginTest()
        {
            Message = "Login clicked";
        }
        private void SignUpButtonClicked()
        {
            mainNavigtion.NavigateTo(App.Locator.SignUpPage);
        }

        public bool AreCredentialsCorrect(User user)
        {
            return user.Username == Constants.Username && user.Password == Constants.Password;
        }

        public async Task<bool> Login(string userName, string password)
        {
            return await Task.FromResult(true);
            //LoginToken token = await loginservice.Login(userName, password);
            //return token != null;
        }

        private  async Task LoginButtonClicked()
        {
            username = "vpillai@sanmanuel.com";
            password = "Lamiv123#";
            Message = "Requesting Login Service";
            var isValid = await Login(Username, Password);
            if (isValid)
            {
                App.IsUserLoggedIn = true;
                mainNavigtion.NavigateTo(App.Locator.MainPage);
            }
            else
            {
                Message = "Login failed";
                Password = string.Empty;
            }
        }
        private string username;
        public string Username
        {
            get { return username; }
            set
            {
                if (value != username)
                {
                    username = value;
                    RaisePropertyChanged("Username");
                }
            }
        }

        private string message;
        public string Message
        {
            get { return message; }
            set
            {
                if (value != message)
                {
                    message = value;
                    RaisePropertyChanged("Message");
                }
            }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                if (value != password)
                {
                    password = value;
                    RaisePropertyChanged("Password");
                }
            }
        }


    }
}
