using Microsoft.AspNetCore.Mvc;
namespace practica2.Controllers
{
    public class FormularioController:Controller
    {
         public IActionResult Index()
        {
            return View();
        } 
         public IActionResult SolicitudAdopcion()
        {
            
              return View();  

         }
          [HttpPost]
         public IActionResult SolicitudAdopcion(string apellido_completo,string mensaje){

           //Console.WriteLine(apellido_completo);
           //Console.WriteLine(mensaje);
            return RedirectToAction("ContactoConfirmacion");
         }

    }
}

