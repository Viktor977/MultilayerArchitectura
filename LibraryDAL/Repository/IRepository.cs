using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDAL.Repository
{
    public interface IRepository<BaseEntity> where BaseEntity : class
    {
        IEnumerable<BaseEntity> GetAll();
        BaseEntity GetBaseEntityById(Guid id);
        BaseEntity UpDate(BaseEntity newEntity);
        bool Create(BaseEntity baseEntity);
        bool Delete(Guid id);
    }
}
