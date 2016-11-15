using GalaSoft.MvvmLight.Ioc;
using SanManuelMobile.Core.Contracts.ViewModel;
using SanManuelMobile.Core.Models;
using System;
using System.Linq;
using Xamarin.Forms;


namespace SanManuelMobile.Core.Views
{
    public partial class NovatusDetail 
    {
        public INovatusDetailViewModel NovotusDetailVM { get; set; }

        [PreferredConstructorAttribute]
        public NovatusDetail()
        {
            try
            {

                InitializeComponent();
                NovotusDetailVM = App.Locator.NovatusDetail;
                this.BindingContext = NovotusDetailVM;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public NovatusDetail(Object someobject)
        {
            var some = someobject;
        }
    }
}
