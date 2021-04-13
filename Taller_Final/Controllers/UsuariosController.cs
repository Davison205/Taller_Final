using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taller_Final.Models.Entities;
using Taller_Final.ViewModels.Usuario;

namespace Taller_Final.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly UserManager<UsuarioIdentity> _userManager;
        private readonly SignInManager<UsuarioIdentity> _signInManager;

        public UsuariosController(UserManager<UsuarioIdentity> userManager, SignInManager<UsuarioIdentity> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;

        }
        public async Task<IActionResult> Index()
        {
            var usuarios = await _userManager.Users.ToListAsync();
            return View(usuarios);
        }
        public IActionResult CrearUsuario()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CrearUsuario(UsuarioViewModel usuarioViewModel)
        {
           if (ModelState.IsValid)
            {
                UsuarioIdentity usuario = new UsuarioIdentity
                {
                    UserName = usuarioViewModel.Email,
                    Email = usuarioViewModel.Email,
                    Nombre = usuarioViewModel.Nombre,
                    Documento = usuarioViewModel.Documento
                };
                try
                {
                    var result = await _userManager.CreateAsync(usuario, usuarioViewModel.Password);

                    if (result.Succeeded)
                    {
                        TempData["Accion"] = "Crear";
                        TempData["Mensaje"] = "Usuario creado";
                        return RedirectToAction("Index");
                    }

                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
                catch (Exception)
                {

                    return View(usuarioViewModel);
                }
            }

            return View(usuarioViewModel);
        }
    }
}
