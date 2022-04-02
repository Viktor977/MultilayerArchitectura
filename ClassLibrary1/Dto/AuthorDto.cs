using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryBLL.Dto
{
   public  class AuthorDto
    {
        public Guid Id { get; set; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        public string FullName { get; set; }
        public string MiddleName { get; set; }
        public DateTime dateOfBirst { get; set; }

    }
}
