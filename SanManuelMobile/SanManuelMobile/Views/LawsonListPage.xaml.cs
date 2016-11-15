using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SanManuelMobile.Core.Views
{
    public partial class LawsonListPage : ContentPage
    {
        public class LawsonData
        {
            public string RequestNo { get; set; }
            public string Requestor { get; set; }
            public int OrderNo { get; set; }
            public string RequestDescription { get; set; }

        }
        public List<LawsonData> LawsonListModel =null;
        public LawsonListPage()
        {
            InitializeComponent();
            LawsonListModel = new List<LawsonData> {
                   new LawsonData
                   {
                       RequestNo = "950JMF",
                       Requestor = "Jody Fox",
                       OrderNo= 249,
                       RequestDescription = "Office Supplies"
                   },
                    new LawsonData
                    {
                        RequestNo = "951JMF",
                        Requestor = "Aaron S",
                         OrderNo= 250,
                        RequestDescription = "Casino Supplies"
                    },
                     new LawsonData
                     {
                         RequestNo = "952JMF",
                         Requestor = "Dominic Gilmour",
                          OrderNo= 251,
                         RequestDescription = "Architecture Supplies"
                     },
                      new LawsonData
                      {
                          RequestNo = "953JMF",
                          Requestor = "Edward P",
                          OrderNo= 252,
                          RequestDescription = "Development Supplies"
                      }
                    };
            this.BindingContext = LawsonListModel;
        }
    }
}
