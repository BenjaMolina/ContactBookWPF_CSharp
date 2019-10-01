using ContactBookWPF.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ContactBookWPF.ViewModels
{
    public class BookViewModel : BaseViewModel
    {
        private ContactsViewModel _contactsVM;
        public ContactsViewModel ContactsVM
        {
            get => _contactsVM;
            set => OnPropertyChanged(ref _contactsVM, value);
        }

        public ICommand LoadContactsCommand { get; private set; }
        public ICommand LoadFavoritesCommand { get; private set; }

        public BookViewModel()
        {
            ContactsVM = new ContactsViewModel();
            LoadContactsCommand = new RelayCommand(LoadContacts);
            LoadFavoritesCommand = new RelayCommand(LoadFavorites);
        }

        private void LoadContacts()
        {

        }

        private void LoadFavorites()
        {

        }
    }
}
