
using SanManuelMobile.Core.Utility;
using SanManuelMobile.Core.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SanManuelMoby.ViewModel
{
    
   
        public class MenuItem :BaseViewModel
        {
            private bool _isSelected;

            public string Title { get; set; }
            public Type ViewModelType { get; set; }
            public MenuOption Option { get; set; }
            public bool IsSelected
            {
                get
                {
                    return _isSelected;
                }
                set
                {
                    _isSelected = value;
                    //OnPropertyChanged();
                }
            }
        }
    
}
