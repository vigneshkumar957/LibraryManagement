using System;
using System.Collections.Generic;
using LMS.ViewModels.Pager;
using LMS.DataAccess.Entities;

namespace LMS.ViewModels.Publishers
{
    public class PublishersIndexVM
    {
        public string PublisherName { get; set; }
        public string PublisherAddress { get; set; }

        public IEnumerable<Publisher> PublishersList { get; set; }
        public GenericPagerVM PublishersPager { get; set; }
    }
}