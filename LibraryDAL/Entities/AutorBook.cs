using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDAL.Entities
{
    public class AutorBook : BaseEntity
    {
        public Guid AuthorId { get; set; }
        public Guid BookId { get; set; }
        //public IEnumerable<Author> Authors { get; set; }
        //public IEnumerable<Book> Books { get; set; }
    }
}
