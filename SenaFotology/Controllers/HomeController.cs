using Microsoft.AspNetCore.Mvc;
using SenaFotology.Models;
using System.Diagnostics;
using static SenaFotology.Models.LoginViewModel;

namespace SenaFotology.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult IniciarSesionUsuario(string Email, string Clave)
        {
            // Lógica de la acción IniciarSesionUsuario
            return View();
        }

        [HttpPost]
        public ActionResult IniciarSesionUsuario(LoginViewModel model)
        {
            // Aquí deberías implementar la lógica de autenticación
            // Verifica el correo electrónico y la contraseña en tu base de datos
            // En un escenario real, reemplaza el siguiente código con tu propia lógica

            if (IsValidUser(model.Email, model.Clave))
            {
                // Redirige a un panel de usuario o página principal después de un inicio de sesión exitoso
                return RedirectToAction("PaginaCliente");
            }
            else
            {
                // Redirige de nuevo a la página de inicio de sesión con un mensaje de error
                return RedirectToAction("Index", new { error = "Credenciales inválidas" });
            }
        }
        public ActionResult PaginaCliente()
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
                return RedirectToAction("PanelDeFotografo");
            }
            else
            {
                // Redirige de nuevo a la página de inicio de sesión con un mensaje de error
                return RedirectToAction("Index", new { error = "Credenciales inválidas" });
            }
        }

        [HttpGet]
        public ActionResult RegistroUsuario()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegistroUsuario(RegistroUsuarioViewModel model)
        {
            // Aquí deberías implementar la lógica de registro de usuario
            // Guarda la información del usuario en la base de datos
            // En un escenario real, reemplaza el siguiente código con tu propia lógica

            // Redirige a la página de inicio de sesión después de un registro exitoso
            return RedirectToAction("Index");
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


        // Se pueden agregar acciones adicionales para Fotógrafo y Administrador de manera similar

        private bool IsValidUser(string email, string password)
        {
            // Aquí deberías implementar la lógica de autenticación
            // Verifica el correo electrónico y la contraseña en tu base de datos
            // Devuelve true si las credenciales son válidas, de lo contrario, false
            // En un escenario real, reemplaza el siguiente código con tu propia lógica
            return true; // Cambia esto con tu lógica de autenticación real
        }
    }
}
