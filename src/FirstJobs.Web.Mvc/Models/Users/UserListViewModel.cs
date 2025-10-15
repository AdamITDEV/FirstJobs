using System.Collections.Generic;
using FirstJobs.Roles.Dto;

namespace FirstJobs.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
