using ContactBookWPF.Models;
using ContactBookWPF.Utility;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBookWPF.ViewModels
{
    public class ContactsViewModel : BaseViewModel
    {
        private Contact _selectedContact;
        public Contact SelectedContact
        {
            get => _selectedContact;
            set => OnPropertyChanged(ref _selectedContact, value);
        }

        public ObservableCollection<Contact> Contacts { get; private set; }

        public ContactsViewModel()
        {

        }

        public void LoadContacts(IEnumerable<Contact> contacts)
        {
            Contacts = new ObservableCollection<Contact>(contacts);
            OnPropertyChanged("Contacts");
        }
    }
}
