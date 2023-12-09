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
            // L�gica de la acci�n IniciarSesionUsuario
            return View();
        }

        [HttpPost]
        public ActionResult IniciarSesionUsuario(LoginViewModel model)
        {
            // Aqu� deber�as implementar la l�gica de autenticaci�n
            // Verifica el correo electr�nico y la contrase�a en tu base de datos
            // En un escenario real, reemplaza el siguiente c�digo con tu propia l�gica

            if (IsValidUser(model.Email, model.Clave))
            {
                // Redirige a un panel de usuario o p�gina principal despu�s de un inicio de sesi�n exitoso
                return RedirectToAction("PaginaCliente");
            }
            else
            {
                // Redirige de nuevo a la p�gina de inicio de sesi�n con un mensaje de error
                return RedirectToAction("Index", new { error = "Credenciales inv�lidas" });
            }
        }
        public ActionResult PaginaCliente()
        {
            return View();
        }
        public ActionResult IniciarSesionFotografo()
        {
            // L�gica de la acci�n IniciarSesionFotografo
            return View();
        }

        [HttpPost]
        public ActionResult IniciarSesionFotografo(LoginViewModel model)
        {
            // Aqu� deber�as implementar la l�gica de autenticaci�n
            // Verifica el correo electr�nico y la contrase�a en tu base de datos
            // En un escenario real, reemplaza el siguiente c�digo con tu propia l�gica

            if (IsValidUser(model.Email, model.Clave))
            {
                // Redirige a un panel de usuario o p�gina principal despu�s de un inicio de sesi�n exitoso
                return RedirectToAction("PanelDeFotografo");
            }
            else
            {
                // Redirige de nuevo a la p�gina de inicio de sesi�n con un mensaje de error
                return RedirectToAction("Index", new { error = "Credenciales inv�lidas" });
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
            // Aqu� deber�as implementar la l�gica de registro de usuario
            // Guarda la informaci�n del usuario en la base de datos
            // En un escenario real, reemplaza el siguiente c�digo con tu propia l�gica

            // Redirige a la p�gina de inicio de sesi�n despu�s de un registro exitoso
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
            // Aqu� deber�as implementar la l�gica de registro de usuario
            // Guarda la informaci�n del usuario en la base de datos
            // En un escenario real, reemplaza el siguiente c�digo con tu propia l�gica

            // Redirige a la p�gina de inicio de sesi�n despu�s de un registro exitoso
            return RedirectToAction("Index");
        }


        // Se pueden agregar acciones adicionales para Fot�grafo y Administrador de manera similar

        private bool IsValidUser(string email, string password)
        {
            // Aqu� deber�as implementar la l�gica de autenticaci�n
            // Verifica el correo electr�nico y la contrase�a en tu base de datos
            // Devuelve true si las credenciales son v�lidas, de lo contrario, false
            // En un escenario real, reemplaza el siguiente c�digo con tu propia l�gica
            return true; // Cambia esto con tu l�gica de autenticaci�n real
        }
    }
}
