using helperland.Models;
using helperland.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Security.Claims;

namespace helperland.Controllers
{
    public class AccountController : Controller
    {
        private readonly HelperlandContext _context;
        public AccountController(HelperlandContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult RegisterCustomer()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> RegisterCustomer(SignupCustomerViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _context.Users.Where(f => f.Email == model.Email).FirstOrDefault();
                if (user != null)
                {
                    ModelState.AddModelError(string.Empty, model.Email + "Already Exists");
                }
                else
                {
                    user = new User
                    {
                        FirstName = model.Firstname,
                        LastName = model.LastName,
                        Email = model.Email,
                        MobileNumber = model.Mobile,
                        Password = model.Password,
                        roleId=1,
                        CreatedDate=DateTime.Now,
                    };
                    _context.Users.Add(user);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Faq", "Home");
                }
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult RegisterHelper()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> RegisterHelper(SignupHelperViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _context.Users.Where(f => f.Email == model.Email).FirstOrDefault();
                if (user != null)
                {
                    ModelState.AddModelError(string.Empty, model.Email + "Already Exists");
                }
                else
                {
                    user = new User
                    {
                        FirstName = model.Firstname,
                        LastName = model.LastName,
                        Email = model.Email,
                        MobileNumber = model.Mobile,
                        Password = model.Password,
                        roleId = 2
                    };
                    _context.Users.Add(user);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index", "Home");
                }

            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _context.Users.Where(x => x.Email == model.Email && x.Password == model.Password).FirstOrDefault();
                if(user != null)
                {
                    ModelState.AddModelError(string.Empty, "Invalid Email or Password");
                }
                var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.NameIdentifier,user.UserId.ToString()),
                    new Claim(ClaimTypes.Name,user.Email),
                    new Claim("UserDenied","Whatever")
                };
                var identity=new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);
                var principal=new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal,new AuthenticationProperties { IsPersistent = true });
                return RedirectToAction("Faq", "Home");
            }

            return RedirectToAction("Index", "home");
        }


    }
}
