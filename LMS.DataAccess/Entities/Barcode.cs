using System;
using System.Collections.Generic;
using DataAccess;

namespace LMS.DataAccess.Entities
{
    public class Barcode : BaseEntityWithID
    {
        public int BarcodeNumber { get; set; }
        public int BookID { get; set; }

        public virtual Book Book { get; set; }

        public override string ToString()
        {
            return BarcodeNumber.ToString();
        }
    }
}
