using System;
using LMS.DataAccess.Entities;
using LMS.DataAccess.DataAccessLayer;
using DataAccess;
namespace LMS.DataAccess.Repositories
{
    public class BarcodesRepository : BaseRepository<Barcode>
    {
        public BarcodesRepository(LibraryManagementSystemContext context)
            : base(context)
        {
        }
    }
}
