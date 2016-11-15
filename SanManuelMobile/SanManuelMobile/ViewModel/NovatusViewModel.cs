using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using SanManuelMobile.Core;
using SanManuelMobile.Core.Contracts.Services;
using SanManuelMobile.Core.Models;
using SanManuelMobile.Core.ViewModel;
using SanManuelMoble.Core.Contracts.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SanManuelMoby.ViewModel
{

    public class NovatusViewModel : INevatusViewModel
    {
       
        public RelayCommand<NovatusData> CurrentSelectedItemCommand { get; private set; }

        INavigationService mainNavigtion;
        INovatusService novotusService;

        private List<NovatusData> _novotusListModel = null;
        public List<NovatusData> NovotusListModel
        {
            get
            {
                return _novotusListModel;
            }
            set
            {
                _novotusListModel = value;
                //OnPropertyChanged("EmployeeList");
            }
        }

        /// <summary>
        /// For firing the Details View
        /// </summary>
        /// <param name="selectedItem"></param>
        void SetCurrentSelectedItem(NovatusData selectedItem)
        {
            NovatusDetailViewModel vmodel = App.Locator.NovatusDetail;
            vmodel.CurrentViewModelData = selectedItem;
            mainNavigtion.NavigateTo(App.Locator.NovatusDetailPage);
            //var param = mainNavigtion.GetAndRemoveParameter<string>(Intent);
        }

        public NovatusViewModel(INavigationService navService, INovatusService novService)
        {
            mainNavigtion = navService;
            novotusService = novService;
            NovotusListModel = novotusService.GetNovatusList(App.UserName).Result;
            CurrentSelectedItemCommand = new RelayCommand<NovatusData>(SetCurrentSelectedItem);
        }


      }
       
     
 }
