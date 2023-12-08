using System;
using LMS.DataAccess.Entities;
using LMS.DataAccess.DataAccessLayer;
using DataAccess;

namespace LMS.DataAccess.Repositories
{
    public class PublishersRepository : BaseRepository<Publisher>
    {
        public PublishersRepository(LibraryManagementSystemContext context)
            : base(context)
        {
        }
    }
}
