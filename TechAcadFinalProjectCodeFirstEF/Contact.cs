using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechAcadFinalProjectCodeFirstEF
{
    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public List<ContactNumber> Numbers;

        public Contact()
        {
            Numbers = new List<ContactNumber>();
        }
    }
}
