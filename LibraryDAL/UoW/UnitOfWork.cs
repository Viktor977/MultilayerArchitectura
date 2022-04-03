using LibraryDAL.Context;
using LibraryDAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDAL.UoW
{
    public class UnitOfWork : IDisposable,IUnitOfWork
    {
        private LibraryContext _libraryContext;

        private AutorRepository _authortRepositor;
        public AutorRepository AuthortRepositor
        {
            get
            {
                if (_authortRepositor == null) _authortRepositor = new AutorRepository(_libraryContext);
                return _authortRepositor;
            }
        }

        public UnitOfWork()
        {
            _libraryContext = new LibraryContext();
        }
        public void Dispose()
        {
          
        }
    }
}
