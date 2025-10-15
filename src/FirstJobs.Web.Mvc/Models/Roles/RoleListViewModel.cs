using System.Collections.Generic;
using FirstJobs.Roles.Dto;

namespace FirstJobs.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
