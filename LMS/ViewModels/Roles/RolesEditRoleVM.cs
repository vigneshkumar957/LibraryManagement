﻿using System;
using System.ComponentModel.DataAnnotations;

namespace LMS.ViewModels.Roles
{
    public class RolesEditRoleVM
    {
        public int ID { get; set; }
        
        [Required(ErrorMessage = "* name required")]
        public string Name { get; set; }

        public RolesEditRoleVM()
        {
            Name = "";
        }
    }
}