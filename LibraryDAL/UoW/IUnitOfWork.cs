using LibraryDAL.repo;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDAL.UoW
{
    public interface IUnitOfWork
    {
        public AutorRepository AuthortRepositor { get; }
    }
}
