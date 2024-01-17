using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Pages.ContactsPage
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext context;
        public string errorMessage = "";
        public string successmessage = "";
        [BindProperty]
        public ContactsDto Contactsdto { get; set; } = new ContactsDto();

        public CreateModel(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                errorMessage = "Please provide all required fields.";
                return;
            }

            // Save to the database or perform other necessary actions
            Contacts contacts = new()
            {
                FirstName = Contactsdto.FirstName,
                LastName = Contactsdto.LastName,
                Email = Contactsdto.Email,
                Phone = Contactsdto.Phone,
                ContactType = Contactsdto.ContactType,
                Country = Contactsdto.Country,
                PostalCode= Contactsdto.PostalCode,
            };

             context.contacts.Add(contacts);
             context.SaveChanges();

            Contactsdto.FirstName = string.Empty;
            Contactsdto.LastName = string.Empty;
            Contactsdto.Email = string.Empty;
            Contactsdto.PostalCode =string.Empty;
            Contactsdto.Country = string.Empty;
            Contactsdto.Phone = string.Empty;
            Contactsdto.ContactType = string.Empty;
            ModelState.Clear();
            successmessage = "Contact created successfully.";
        }
    }
}
