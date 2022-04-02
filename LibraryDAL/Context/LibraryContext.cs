using LibraryDAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDAL.Context
{
    public class LibraryContext
    {
        public Guid AothorId { get; set; }
        public Guid BookId { get; set; }
        public IEnumerable<Author> Authors { get; set; }
        public IEnumerable<Book> Books { get; set; }
        public  void Initilazed()
        {
            Author author1 = new Author { LastName = "q", MiddleName = "qw", dateOfBith = DateTime.UtcNow };
            Author author2 = new Author { LastName = "aaa", MiddleName = "sss", dateOfBith = DateTime.UtcNow };
            Author author3 = new Author { LastName = "ppp", MiddleName = "xxx", dateOfBith = DateTime.UtcNow };
            Book b1 = new Book {Name="",Ganre=Ganre.fixition,Amount=100 };

            b1.Autor = new List<AutorBook>() { new AutorBook { AuthorId = author1.Id }, };

            Book b2 = new Book {Name="",Ganre=Ganre.fixition,Amount=100 };
            Book b3 = new Book {Name="",Ganre=Ganre.fixition,Amount=100 };
            Book b4 = new Book {Name="",Ganre=Ganre.fixition,Amount=100 };

        }
    }
}
