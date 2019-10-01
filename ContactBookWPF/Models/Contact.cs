using ContactBookWPF.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBookWPF.Models
{
    public class Contact : BaseViewModel
    {
        private string _name;
        public string Name
        {
            get => _name;
            set => OnPropertyChanged(ref _name, value);
        }

        private string[] _phoneNumber;
        public string[] PhoneNumber
        {
            get => _phoneNumber;
            set => OnPropertyChanged(ref _phoneNumber, value);
        }

        private string[] _emails;
        public string[] Emails
        {
            get => _emails;
            set => OnPropertyChanged(ref _emails, value);
        }

        private string[] _locations;
        public string[] Locations
        {
            get => _locations;
            set => OnPropertyChanged(ref _locations, value);
        }

        private bool _isFavorite;
        public bool IsFavorite
        {
            get => _isFavorite;
            set => OnPropertyChanged(ref _isFavorite, value);
        }

        private string _imagePath;
        public string ImagePath
        {
            get => _imagePath;
            set => OnPropertyChanged(ref _imagePath, value);
        }
    }
}
