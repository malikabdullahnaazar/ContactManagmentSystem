using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Pages.ContactsPage
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext context;
        public List<Contacts> contacts {get;set;} =new List<Contacts>();
        public IndexModel(ApplicationDbContext context)
        {
            this.context = context;
        }
        public void OnGet()
        {
            contacts =context.contacts.OrderByDescending(p=>p.Id).ToList();
        }
    }
}
