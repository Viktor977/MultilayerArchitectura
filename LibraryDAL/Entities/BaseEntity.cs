using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDAL.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public BaseEntity()
        {
            Id = Guid.NewGuid();
        }

    }
}
