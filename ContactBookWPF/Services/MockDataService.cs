using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactBookWPF.Models;

namespace ContactBookWPF.Services
{
    public class MockDataService : IContactDataService
    {
        private IEnumerable<Contact> _contacts;

        public MockDataService()
        {
            _contacts = new List<Contact>()
            {
                new Contact{
                    Name ="Jhon Doe",
                    PhoneNumber = new string[]
                    {
                        "555-111-1111",
                        "555-222-2222"
                    },
                    Emails= new string[]
                    {
                        "John@personal.com",
                        "Jhon@personal.com"
                    },
                    Locations= new string[]
                    {
                        "111 Fake Street",
                        "222 Fake Ave"
                    }
                },
                new Contact
                {
                    Name ="Ronaldinho",
                    PhoneNumber = new string[]
                    {
                        "555-555-5555",
                        "222-222-2222"
                    },
                    Emails= new string[]
                    {
                        "ronaldinho@personal.com",
                        "ronaldinho@personal.com"
                    },
                    Locations= new string[]
                    {
                        "111 Fake Street",
                        "222 Fake Ave"
                    }
                }
            };
        }
        public IEnumerable<Contact> GetContacts()
        {
            return _contacts;
        }

        public void Save(IEnumerable<Contact> contacts)
        {
            _contacts = contacts;
        }
    }
}
