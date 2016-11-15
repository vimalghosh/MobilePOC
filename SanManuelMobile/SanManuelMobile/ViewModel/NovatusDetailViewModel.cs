using System;
using GalaSoft.MvvmLight.Views;
using SanManuelMobile.Core.Contracts.Services;
using SanManuelMobile.Core.Contracts.ViewModel;
using SanManuelMobile.Core.Models;
using GalaSoft.MvvmLight.Command;

namespace SanManuelMobile.Core.ViewModel
{
    public class NovatusDetailViewModel: INovatusDetailViewModel
    {
        private INavigationService mainNavigation;
        private INovatusService novotusService;

        private NovatusData currentViewModelData;

        
        
        public string WorkFlowName { get; set; }
        public string WorkFlowOwner { get; set; }
        public string StepName { get; set; }
        public string StepOwner { get; set; }
        public string Message { get; set; }


        public RelayCommand ApproveCommand { get; set; }
        public RelayCommand DenyCommand { get; set; }
        public RelayCommand CancelCommand { get; set; }
        public RelayCommand LogoutCommand { get; set; }

       
        public NovatusData CurrentViewModelData
        {
            get
            {
                return currentViewModelData;
            }
            set
            {
                currentViewModelData = value;
                SetValues();
            }
        }

        private void SetValues()
        {
            StepOwner = currentViewModelData.StepOwnerName;
            WorkFlowName = currentViewModelData.WorkFlowName;
            WorkFlowOwner = currentViewModelData.WorkFlowOwner;
            StepName = currentViewModelData.StepName;
        }

        public void SetNovatusData(NovatusData data)
        {
            CurrentViewModelData = data;
        }

        public NovatusDetailViewModel(INavigationService navService, INovatusService service)
        {
            mainNavigation = navService;
            novotusService = service;

            LogoutCommand = new RelayCommand(() =>
            {
                App.IsUserLoggedIn = false;
                mainNavigation.NavigateTo(App.Locator.LoginPage);
            });

            DenyCommand = new RelayCommand(() =>
            {
                Message = "Service should be called for denying";
            });

            ApproveCommand = new RelayCommand(() =>
            {
                Message = "Service should be called for approving";
            });

            CancelCommand = new RelayCommand(() =>
            {
                mainNavigation.NavigateTo(App.Locator.NovatusListPage);
            });
        }
    }
}