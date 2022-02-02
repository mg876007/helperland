using Microsoft.AspNetCore.Mvc;

namespace helperland.Controllers
{
    public class SignUpController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
    }
}
