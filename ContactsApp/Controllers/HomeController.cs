using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactsApp.Models;
using ContactsApp.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContactsApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IContactsRepo _contacts;
        public HomeController(IContactsRepo contactsRepo)
        {
            _contacts = contactsRepo;
        }
        [Route("")]
        [Route("Home")]
        [Route("Home/Index")]
        public ViewResult Index() 
        {
            
            var model = _contacts.GetAllContacts();

            return View(model);
        }
        [Route("/{name}")]
        public ViewResult Details(string name)
        {
            if (name == null) throw new ArgumentNullException(nameof(name));
            //name = "sam";
            var model = _contacts.GetContact(name);
            return View(model);
        }
    }
}
