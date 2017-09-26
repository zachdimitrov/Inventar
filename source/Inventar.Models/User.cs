using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventar.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class User
    {
        public string Id { get; set; }

        public UserContacts Contacts { get; set; }

        [NotMapped]
        public string FullName
        {
            get
            {
                return this.Contacts.FirstName + " " + this.Contacts.LastName;
            }
        }
    }
}
