using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class ContactsDto
    {

        public int Id { get; set; }
        [Required,MaxLength(100)]
        public string FirstName { get; set; } = "";
        [Required, MaxLength(100)]
        public string LastName { get; set; } = "";
        [Required, MaxLength(100)]
        public string Email { get; set; } = "";
        [Required, MaxLength(100)]
        public string ContactType { get; set; } = "";
        [Required, MaxLength(12)]
        public string Phone { get; set; } = "";
        [MaxLength(100),Required]
        public string PostalCode { get; set; } = "";
        public string Country { get; set; } = "";
    }
}
