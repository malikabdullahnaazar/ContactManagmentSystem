using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Contacts
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string FirstName { get; set; } = "";
        [MaxLength(100)]
        public string LastName { get; set; } = "";
        [MaxLength(100)]
        public string Email { get; set; } = "";
        [MaxLength(100)]
        public string ContactType { get; set; } = "";
        [MaxLength(100)]
        public string Phone { get; set; } = "";
        [MaxLength(100), Required]
        public string PostalCode { get; set; } = "";
        public string Country { get; set; } = "";
    }
}
