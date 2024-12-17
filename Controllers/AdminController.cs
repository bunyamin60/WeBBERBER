using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WeBBERBER.Controllers
{
    public class AdminController : Controller
    {
        [Authorize("admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
