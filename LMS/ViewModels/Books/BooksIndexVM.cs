using System;
using System.Collections.Generic;
using LMS.ViewModels.Pager;
using LMS.DataAccess.Entities;

namespace LMS.ViewModels.Books
{
    public class BooksIndexVM
    {
        public string Title { get; set; }
        public string Publisher { get; set; }

        public List<Book> BooksList { get; set; }
        public GenericPagerVM BooksPager { get; set; }
    }
}