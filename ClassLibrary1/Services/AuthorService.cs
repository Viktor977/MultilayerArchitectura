using AutoMapper;
using LibraryBLL.Dto;
using LibraryDAL.Entities;
using LibraryDAL.UoW;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryBLL.Services
{
    public class AuthorService : IAuthorService
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;

        public AuthorService(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        //public AuthorService(IUnitOfWork unitOfWork)
        //{
        //    _unitOfWork = unitOfWork;
        //    _mapper = new MapperConfiguration(cfs => 
        //    {
        //        cfs.AddProfile(new MapperConfigurator());
        //    }
                
        //        );
        //}
        public IEnumerable<AuthorDto> GetAllAuthors()
        {
            var unmappedAuthors = _unitOfWork.AuthortRepositor.GetAll();//TODO

            var mappedAuthors = _mapper.Map<IEnumerable<Author>, IEnumerable<AuthorDto>>(unmappedAuthors);

            return mappedAuthors;
        }
    }
}
