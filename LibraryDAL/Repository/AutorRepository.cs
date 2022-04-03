using LibraryDAL.Context;
using LibraryDAL.Entities;
using LibraryDAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryDAL.Repository
{
    public class AutorRepository : IRepository<Author>
    {
        private LibraryContext _libraryContext;
        public AutorRepository(LibraryContext context)
        {
            _libraryContext = context;
        }
        public bool Create(Author baseEntity)
        {
            var authors = _libraryContext.Authors.ToList();
            authors.Add(baseEntity);
            if (authors.Contains(baseEntity))
            {
                return true;
            }
            return false;
        }

      

        public bool Delete(Guid id)
        {
            var authors = _libraryContext.Authors.ToList();
            var authhorForDelete=
             _libraryContext.Authors.FirstOrDefault(t => t.Id == id);
            if (authhorForDelete == null)
            {
               // throw new NullReferenceException();
                return false;
            }
            authors.Remove(authhorForDelete);
            return true;
        }

        public IEnumerable<Author> GetAll()
        {
            var authors = _libraryContext.Authors;
            return authors;
        }

        public Author GetBaseEntityById(Guid id)
        {
          var authors=  _libraryContext.Authors.ToList();
            var author = authors.FirstOrDefault(t => t.Id == id);
            if (author == null)
            {
                throw new InvalidOperationException("There is no author with sach id");
            }
            return author;
        }

        public Author UpDate(Author newAuthor)
        {
            var author = _libraryContext.Authors.FirstOrDefault(t => t.Id == newAuthor.Id);
            if (author == null)
            {
                throw new InvalidOperationException();
            }
            author.LastName = newAuthor.LastName;
            author.MiddleName = newAuthor.MiddleName;
            author.dateOfBith = newAuthor.dateOfBith;
            author.FirstName = newAuthor.FirstName;
            author.Book = newAuthor.Book;
 
            return author;

        }

        
    }
}
