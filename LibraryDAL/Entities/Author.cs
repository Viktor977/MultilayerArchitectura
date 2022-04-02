using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDAL.Entities
{
    public class Author : BaseEntity
    {

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime dateOfBith { get; set; }
        public IEnumerable<AutorBook> Book { get; set; }



    }
}
