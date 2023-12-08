using System;
using System.Collections.Generic;
using System.Web;
using System.Web.WebPages.Html;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using LMS.DataAccess.Entities;

namespace LMS.ViewModels.Publishers
{
    public class PublishersEditPublisherVM
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "* name required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "* address required")]
        public string Address { get; set; }       
    }
}