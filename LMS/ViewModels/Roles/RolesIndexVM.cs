using System;
using System.Collections.Generic;
using LMS.ViewModels.Pager;
using LMS.DataAccess.Entities;

namespace LMS.ViewModels.Roles
{
    public class RolesIndexVM
    {
        public List<Role> RolesList { get; set; }
        public GenericPagerVM RolesPager { get; set; }
    }
}