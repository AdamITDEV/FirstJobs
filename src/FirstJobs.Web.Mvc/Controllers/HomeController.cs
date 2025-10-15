using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using FirstJobs.Controllers;

namespace FirstJobs.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : FirstJobsControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
