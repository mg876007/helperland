using helperland.Models;
using helperland.Repository;
using helperland.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace helperland.Controllers
{
    public class ContactController : Controller
    {
        private readonly ContactRepository _contactRepository;
        public ContactController(ContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }
        [HttpGet]
        public IActionResult Index(bool isSuccess=false)
        {
            ViewBag.IsSuccess = isSuccess;
            return View();
        }
        [HttpPost]
        public IActionResult Index(ContactViewModel contactmodel)
        {
            if (ModelState.IsValid)
            {
                int id = _contactRepository.Contact(contactmodel);
                if (id > 0)
                {
                    return RedirectToAction(nameof(Index), new { isSuccess = true });
                }
            }
            ModelState.AddModelError("", "Please fill All fields..");
            return View();
        }
    }
}
