using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using LMS.ViewModels.Pager;
using LMS.DataAccess.Entities;

namespace LMS.ViewModels.Authors
{
    public class AuthorsDetailsVM
    {
        public int ID { get; set; }

        [DisplayName("Author")]
        public string AuhtorName { get; set; }

        [DisplayName("Book")]
        public string BookTitle { get; set; }

        [DisplayName("Publisher")]
        public string PublisherName { get; set; }

        public List<Book> Books { get; set; }
        public GenericPagerVM BooksPager { get; set; }
    }
}