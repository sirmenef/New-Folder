using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactsApp.Models;

namespace ContactsApp.ViewModels
{
    public class HomeIndexViewModels
    {
        public IEnumerable<Contacts> Contacts { get; set; }
        public string PageTitle { get; set; }
    }
}
