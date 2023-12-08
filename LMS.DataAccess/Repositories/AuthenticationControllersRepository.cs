using System;
using LMS.DataAccess.Entities;
using LMS.DataAccess.DataAccessLayer;
using DataAccess;

namespace LMS.DataAccess.Repositories
{
    public class AuthenticationControllersRepository : BaseRepository<AuthenticationController>
    {
        public AuthenticationControllersRepository(LibraryManagementSystemContext context)
            : base(context)
        {
        }

        public AuthenticationControllersRepository(UnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
