using ContactBookWPF.Utility;
using ContactBookWPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBookWPF
{
    public class AppViewModel : BaseViewModel
    {
        private object _currentView;
        public object CurrentView
        {
            get => _currentView;
            set => OnPropertyChanged(ref _currentView, value);
        }

        private BookViewModel _bookVM;
        public BookViewModel BookVM
        {
            get => _bookVM;
            set => OnPropertyChanged(ref _bookVM, value);
        }

        public AppViewModel()
        {
            BookVM = new BookViewModel();
            CurrentView = BookVM;
        }
    }
}
