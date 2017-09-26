namespace Inventar.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    [ComplexType]
    public class UserContacts
    {
        [Column("Email")]
        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}