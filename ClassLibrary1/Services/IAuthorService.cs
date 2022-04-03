using LibraryBLL.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryBLL.Services
{
    public interface IAuthorService
    {
        IEnumerable<AuthorDto> GetAllAuthors();
    }
}
