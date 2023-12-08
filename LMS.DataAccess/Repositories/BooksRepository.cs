using System;
using LMS.DataAccess.Entities;
using LMS.DataAccess.DataAccessLayer;
using DataAccess;


namespace LMS.DataAccess.Repositories
{
    public class BooksRepository : BaseRepository<Book>
    {
        public BooksRepository(LibraryManagementSystemContext context)
            : base(context)
        {
        }
    }
}
