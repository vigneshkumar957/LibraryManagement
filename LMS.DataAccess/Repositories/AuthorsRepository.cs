using System;
using LMS.DataAccess.Entities;
using LMS.DataAccess.DataAccessLayer;
using DataAccess;

namespace LMS.DataAccess.Repositories
{
    public class AuthorsRepository : BaseRepository<Author>
    {
        public AuthorsRepository(LibraryManagementSystemContext context)
            : base(context)
        {
        }
    }
}
