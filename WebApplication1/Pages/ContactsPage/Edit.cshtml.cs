using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Pages.ContactsPage
{
   
   
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext context;
        public string errorMessage = "";
        public Contacts Contacts { get; set; }= new Contacts();
        public string successmessage = "";
        [BindProperty]

        public ContactsDto Contactsdto { get; set; } = new ContactsDto();
        public EditModel(ApplicationDbContext context)
        {
            this.context = context;
        }
        public void OnGet(int? id)
        {
            if (id == null)
            {
                Response.Redirect("/ContactPage/Index");
                return;
            }
            var product = context.contacts.Find(id);
            if (product == null)
            {
                Response.Redirect("/ContactPage/Index");
                return;
            }
           Contactsdto.FirstName = product.FirstName;
            Contactsdto.LastName = product.LastName;
            Contactsdto.Email = product.Email;
            Contactsdto.Phone = product.Phone;
            Contactsdto.PostalCode = product.PostalCode;
            Contactsdto.Country = product.Country;
            Contactsdto.ContactType = product.ContactType;
            Contacts = product;
        }
    }
}
