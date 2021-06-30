using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ClarkCodingChallenge.Models;
using ClarkCodingChallenge.Utilities;
using System.Collections.Generic;

namespace ClarkCodingChallenge.Controllers
{
    public class ContactsController : Controller
    {
        private readonly ContactRepository _contactRepository;

        public ContactsController(ContactRepository contactRepo)
        {
            _contactRepository = contactRepo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddContacts()
        {
            return View();
        }

        public IActionResult AddContactConfirmation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddContacts(string firstName, string lastName, string email)
        {
            // TODO: implement if you have time to look into displaying alert boxes
            if (string.IsNullOrEmpty(firstName))
            {
                // show alert box "First name is required"
                return View("AddContacts"); // remove once alert box implemented
            }
            else if (string.IsNullOrEmpty(firstName))
            {
                // show alert box "First name is required"
                return View("AddContacts"); // remove once alert box implemented
            } else if (!ValidityUtilities.IsValidEmail(email))
            {
                // show alert box "Please provide a valid email address."
                return View("AddContacts"); // remove once alert box implemented
            }

            ContactModel newContact = new ContactModel()
            {
                FirstName = firstName.Trim(),
                LastName = lastName.Trim(),
                Email = email.Trim()
            };

            _contactRepository.Add(newContact);

            return View("AddContactConfirmation");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
