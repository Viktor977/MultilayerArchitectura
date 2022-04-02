using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDAL.Entities
{
   public class Book :BaseEntity
    {
      
        public string Name { get; set; }
        public DateTime YearOfPubliching { get; set; }
        public int Amount { get; set; }
        public Ganre Ganre { get; set; }
        public IEnumerable<AutorBook> Autor { get; set; }
    }
}
