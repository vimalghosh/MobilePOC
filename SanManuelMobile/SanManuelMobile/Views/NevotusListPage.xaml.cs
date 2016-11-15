using GalaSoft.MvvmLight.Command;
using SanManuelMoby.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace SanManuelMobile.Core.Views
{
    public partial class NovotusListPage : ContentPage
    {

        NovatusViewModel novatusVM;
        public NovotusListPage()
        {
            InitializeComponent();
            novatusVM = App.Locator.NovatusList;
            BindingContext = novatusVM;

        }
    }
}

