// src/FirstJobs.Web.Mvc/Controllers/ContactsController.cs
using Abp.AspNetCore.Mvc.Authorization;
using FirstJobs.Authorization;
using FirstJobs.Controllers;
using Microsoft.AspNetCore.Mvc;

[AbpMvcAuthorize(PermissionNames.Pages_Contacts)]
public class ContactsController : FirstJobsControllerBase
{
    public ActionResult Index() => View();
    public PartialViewResult EditModal() => PartialView("_EditModal");
}
