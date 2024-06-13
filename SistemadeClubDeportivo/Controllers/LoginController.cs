﻿using Microsoft.AspNetCore.Mvc;
using SistemadeClubDeportivo.Contexto;

namespace SistemadeClubDeportivo.Controllers
{
    public class LoginController : Controller
    {
        MyContexto _context;

        public LoginController(MyContexto context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login (string email, string password)
        {
            var usuario = _context.Usuarios.Where(x => x.Email == email).Where(x => x.Password == password).FirstOrDefault();
            if (usuario != null)
            {
                return RedirectToAction("Index","Home");
            }
            else
            {
                TempData["LoginError"] = "Cuenta o Password incorrectos";
                return RedirectToAction("Index", "Login");
            }
            return RedirectToAction("Index", "Login");
        }
        public async Task<IActionResult> Logout()
        {
            return RedirectToAction("Index", "Login");
        }
    }
}
