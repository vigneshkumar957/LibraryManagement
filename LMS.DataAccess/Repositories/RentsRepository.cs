using System;
using LMS.DataAccess.Entities;
using LMS.DataAccess.DataAccessLayer;
using DataAccess;

namespace LMS.DataAccess.Repositories
{
    public class RentsRepository : BaseRepository<Rent>
    {
        public RentsRepository(LibraryManagementSystemContext context)
            : base(context)
        {
        }
    }
}
