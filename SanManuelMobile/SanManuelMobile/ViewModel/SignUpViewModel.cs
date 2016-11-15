using SanManuelMobile.Core.Contracts.Services;
using SanManuelMobile.Core.Models;
using SanManuelMobile.Core.Services;
using SanManuelMobile.Core.ViewModel;
using SanManuelMoble.Core.Contracts.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SanManuelMobile.Core.ViewModel
{
    public class SignUpViewModel: BaseViewModel,ISignUpViewModel
    {
        ILoginService loginservice;

        public SignUpViewModel(ILoginService service)
        {
            loginservice = service;
        }

        public bool AreCredentialsCorrect(User user)
        {
            return user.Username == Constants.Username && user.Password == Constants.Password;
        }

        public async Task<bool> Register(User user)
        {
            return await Task.FromResult(false);
        }

    }
}
