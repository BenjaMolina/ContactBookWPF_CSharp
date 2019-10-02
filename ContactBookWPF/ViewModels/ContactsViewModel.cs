using ContactBookWPF.Models;
using ContactBookWPF.Services;
using ContactBookWPF.Utility;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

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

        private bool _isEditMode;
        public bool IsEditMode
        {
            get => _isEditMode;
            set
            {
                OnPropertyChanged(ref _isEditMode, value);
                OnPropertyChanged("IsDisplayMode");
            }
        }

        public bool IsDisplayMode
        {
            get => !_isEditMode;
        }

        public ObservableCollection<Contact> Contacts { get; private set; }
        public ICommand EditCommand { get; private set; }
        public ICommand SaveCommand { get; private set; }
        private IContactDataService _service;

        public ContactsViewModel(IContactDataService service)
        {
            EditCommand = new RelayCommand(Edit, CanEdit);
            SaveCommand = new RelayCommand(Save, IsEdit);
            _service = service;
        }

        private bool CanEdit()
        {
            if (SelectedContact == null)
                return false;

            return !IsEditMode;
        }

        private void Edit()
        {
            IsEditMode = true;
        }

        private bool IsEdit()
        {
            return IsEditMode;
        }

        private void Save()
        {
            _service.Save(Contacts);
            IsEditMode = false;
            OnPropertyChanged("SelectedContact");
        }

        public void LoadContacts(IEnumerable<Contact> contacts)
        {
            Contacts = new ObservableCollection<Contact>(contacts);
            OnPropertyChanged("Contacts");
        }
    }
}
