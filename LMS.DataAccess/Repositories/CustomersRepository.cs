using System;
using LMS.DataAccess.Entities;
using LMS.DataAccess.DataAccessLayer;
using DataAccess;

namespace LMS.DataAccess.Repositories
{
    public class CustomersRepository : BaseRepository<Customer>
    {
        public CustomersRepository(LibraryManagementSystemContext context)
            :base(context)
        {
        }
    }
}
