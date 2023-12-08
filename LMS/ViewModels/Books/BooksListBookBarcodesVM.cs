﻿using System;
using System.Collections.Generic;
using LMS.ViewModels.Pager;
using LMS.DataAccess.Entities;

namespace LMS.ViewModels.Books
{
    public class BooksListBookBarcodesVM
    {        
        public int BookID { get; set; }
        public string BookTitle { get; set; }
        public List<Barcode> Barcodes { get; set; }
        public GenericPagerVM BarcodesPager { get; set; }
    }
}