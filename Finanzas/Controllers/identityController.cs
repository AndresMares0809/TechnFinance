using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Finanzas.Models;
using Finanzas.Models.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Finanzas.Controllers
{
    public class identityController : Controller
    {
        private readonly UserManager<Bodeguero> _userManager;
        private readonly SignInManager<Bodeguero> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public identityController(
        UserManager<Bodeguero> userManager,
        RoleManager<IdentityRole> roleManager,
        SignInManager<Bodeguero> signInManager)
        {

            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }
        [HttpGet]
        public async Task<IActionResult> Login()
        {
            bool x = await _roleManager.RoleExistsAsync("Bodeguero");
            if (!x)
            {
                // first we create Admin rool    
                var role = new IdentityRole();
                role.Name = "Bodeguero";
                await _roleManager.CreateAsync(role);
            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel userInfo)
        {
            if (ModelState.IsValid)
            {
                Bodeguero signedUser = await _userManager.FindByNameAsync(userInfo.RUC);
                if (signedUser != null) { 
                var result = await _signInManager.PasswordSignInAsync(userInfo.RUC, userInfo.Password, isPersistent: false, lockoutOnFailure: false);
                 if (!result.Succeeded)
                {
                        ViewBag.Error = "Credenciales incorrectas";
                        return View(userInfo);
                }
                    return RedirectToAction("Index", "Home");
                }
                ViewBag.Error = "Numero de RUC no encontrado";
                return View(userInfo);
            }
            return View(userInfo);
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel userInfo)
        {
            if (ModelState.IsValid)
            {
                var user = new Bodeguero
                {
                    UserName = userInfo.RUC,
                    Email = userInfo.Email,
                    FirstName = userInfo.FirstName,
                    LastName = userInfo.LastName,
                    Address = userInfo.Address,
                    DNI = userInfo.DNI,
                    RUC = userInfo.RUC,
                    RazonSocial=userInfo.RazonSocial
                };
                var result = await _userManager.CreateAsync(user,userInfo.Password);
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "Bodeguero");
                    return RedirectToAction("Login", new LoginViewModel { RUC = user.RUC, Password = userInfo.Password });
                }
                ViewBag.Errores=result.Errors.Select(d => d.Description).ToList();
                return View(userInfo);
            }
            return View(userInfo);
        }
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }
        [HttpGet]
        public async Task<IActionResult> CambiarClave()
        {
            return View();
        }
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CambiarClave(ChangePassword userInfo)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var result=await _userManager.ChangePasswordAsync(user, userInfo.Password, userInfo.newPassword);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }
            ViewBag.Error = "Credenciales Incorrectas";
            return View(userInfo);
        }

    }
}