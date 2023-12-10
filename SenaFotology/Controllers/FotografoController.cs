using Microsoft.AspNetCore.Mvc;
using SenaFotology.Models;
using static SenaFotology.Models.LoginViewModel;

namespace SenaFotology.Controllers
{
    public class FotografoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult IniciarSesionFotografo()
        {
            // Lógica de la acción IniciarSesionFotografo
            return View();
        }

        [HttpPost]
        public ActionResult IniciarSesionFotografo(LoginViewModel model)
        {
            // Aquí deberías implementar la lógica de autenticación
            // Verifica el correo electrónico y la contraseña en tu base de datos
            // En un escenario real, reemplaza el siguiente código con tu propia lógica

            if (IsValidUser(model.Email, model.Clave))
            {
                // Redirige a un panel de usuario o página principal después de un inicio de sesión exitoso
                return RedirectToAction("FotografoPagina");
            }
            else
            {
                // Redirige de nuevo a la página de inicio de sesión con un mensaje de error
                return RedirectToAction("Index", new { error = "Credenciales inválidas" });
            }
        }

        private bool IsValidUser(string email, string clave)
        {
            // Lógica de validación de usuario
            // Por ejemplo, puedes consultar tu base de datos para validar las credenciales

            // Simulando una validación simple
            return (email == "usuario@dominio.com" && clave == "contraseña");
        }

        [HttpGet]
        public ActionResult RegistroFotografo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegistroFotografo(RegistroFotografoViewModel model)
        {
            // Aquí deberías implementar la lógica de registro de usuario
            // Guarda la información del usuario en la base de datos
            // En un escenario real, reemplaza el siguiente código con tu propia lógica

            // Redirige a la página de inicio de sesión después de un registro exitoso
            return RedirectToAction("Index");
        }
    }
}
