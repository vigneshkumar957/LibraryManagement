using System;
using LMS.DataAccess.Entities;
using LMS.DataAccess.DataAccessLayer;
using DataAccess;

namespace LMS.DataAccess.Repositories
{
    public class UsersRepository : BaseRepository<User>
    {
        public UsersRepository(LibraryManagementSystemContext context)
            : base(context)
        {
        }       

        public UsersRepository(UnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
