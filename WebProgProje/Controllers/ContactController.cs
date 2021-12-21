using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProgProje.Models;

namespace WebProgProje.Controllers
{
    public class ContactController : Controller
    {
        PaperContext paperContext;

        public ContactController(PaperContext context)
        {
            paperContext = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddContact([Bind("Name, Email, Phone, Content")] Contact contact)
        {
            Contact _contact = new Contact();

            _contact.Name = contact.Name;
            _contact.Email = contact.Email;
            _contact.Phone = contact.Phone;
            _contact.Content = contact.Content;
            _contact.DateOfComment = DateTime.Now;
            _contact.isRead = false;

            paperContext.Contacts.Add(_contact);
            paperContext.SaveChanges();

            return View();
        }


    }
}
