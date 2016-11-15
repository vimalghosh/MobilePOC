using System.Collections.ObjectModel;
using System.Threading.Tasks;
using SanManuelMobile.Core.Contracts.Services;
using SanManuelMobile.Core.Models;
using SanManuelMobile.Core.ViewModel;
using SanManuelMoble.Core.Contracts.ViewModel;

namespace SanManuelMoby.ViewModel
{


        public class SettingsViewModel : BaseViewModel, ISettingsViewModel
        {


        private readonly ISettingsDataService _settingsDataService;
        private string _aboutContent;
     

        public SettingsViewModel(ISettingsDataService settingsDataService)
        {
            _settingsDataService = settingsDataService;
        }

          /*  public MvxCommand HelpCommand
            {
                get
                {
                    return new MvxCommand(() =>
                    {
                        _webBrowser.ShowWebPage
                            ("http://www.sanmanuel.com");//The Site about the application
                    });
                }
            }*/
        

           

            public string AboutContent
            {
                get { return _aboutContent; }
                set
                {
                    _aboutContent = value;
                   // RaisePropertyChanged(() => AboutContent);
                }
            }

           /* public SettingsViewModel(IMvxMessenger messenger, ISettingsDataService settingsDataService, IMvxWebBrowserTask webBrowser) : base(messenger)
            {
                _settingsDataService = settingsDataService;
                _webBrowser = webBrowser;

            }*/



            //public override async void Start()
            //{
            //    base.Start();
            //    await ReloadDataAsync();
            //}

            //protected override Task InitializeAsync()
            //{
            //    return Task.Run(() =>
            //    {
            //        AboutContent = _settingsDataService.GetAboutContent();
                  
            //    });
            //}
        }
 }

