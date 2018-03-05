using System.Web.Mvc;
using Abp.Dependency;
using MyProject.BookService;

namespace MyProject.Web.Controllers
{
    public class HomeController : MyProjectControllerBase
    {
        public ActionResult Index()
        {
            IocManager.Instance.Resolve<IBookAppService>().Creat();
            //IocManager.Instance.Resolve<IBookAppService>().Update();
            return View();
        }
	}
}