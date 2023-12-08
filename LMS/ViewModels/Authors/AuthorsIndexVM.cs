using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using LMS.ViewModels.Pager;
using LMS.DataAccess.Entities;

namespace LMS.ViewModels.Authors
{
    public class AuthorsIndexVM
    {
        [DisplayName("Name")]
        public string AuthorName { get; set; }

        public IEnumerable<Author> AuthorsList { get; set; }
        public GenericPagerVM AuthorsPager { get; set; }        
    }
}