using System;
using LMS.DataAccess.Entities;
using LMS.DataAccess.DataAccessLayer;
using DataAccess;

namespace LMS.DataAccess.Repositories
{
    public class AuthenticatingActionsRepository : BaseRepository<AuthenticatingAction>
    {
         public AuthenticatingActionsRepository(LibraryManagementSystemContext context)
            : base(context)
        {
        }

         public AuthenticatingActionsRepository(UnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
