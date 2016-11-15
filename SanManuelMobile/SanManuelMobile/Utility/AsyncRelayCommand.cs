using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanManuelMobile.Core.Utility
{
    public class AsyncRelayCommand : RelayCommand
    {
        private readonly Func<Task> _asyncExecute;

        public AsyncRelayCommand(Func<Task> asyncExecute)
            : base(() => asyncExecute())
        {
            _asyncExecute = asyncExecute;
        }

        public AsyncRelayCommand(Func<Task> asyncExecute, Action execute)
            : base(execute)
        {
            _asyncExecute = asyncExecute;
        }

        public Task ExecuteAsync()
        {
            return _asyncExecute();
        }

        //Overriding Execute like this fixes my problem, but the question remains unanswered.
        //public override void Execute(object parameter)
        //{
        //    _asyncExecute();
        //}
    }
}
