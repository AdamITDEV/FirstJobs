using System.Collections.Generic;
using FirstJobs.Roles.Dto;

namespace FirstJobs.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}