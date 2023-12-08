using System.Web.Mvc;
using LMS.Filters;

namespace LMS.Controllers
{
    [LoginFilter]
    public class BaseController : Controller
    {
    }
}