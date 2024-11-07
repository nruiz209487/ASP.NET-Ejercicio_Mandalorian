using EjercicioMandalorianASP.Models.BL;
using EjercicioMandalorianASP.Models.ENT;
using Mandalorian.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Mandalorian.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        /// <summary>
        /// List privada lista msion que seigauala a ObtenerMisionesBL
        /// </summary>
        private List<ClsMision> listaMisiones;
        /// <summary>
        /// objeto ClsMision sin inicializar
        /// </summary>
        private ClsMision mision;

        /// <summary>
        /// HomeController 
        /// </summary>
        /// <param name="logger"></param>
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// controlador de Index si la listaMisiones es null envia un mensaje si no una lista
        /// </summary>
        /// <returns>devuelve la vista</returns>
        public IActionResult Index()
        {

            try 
            {
                listaMisiones = clsListadoMisionesBL.ObtenerMisionesBL();
            }
            catch (Exception ex)
            {
                return Content("Se ha producdo un error.");
            }
            if (listaMisiones == null)
            {
                return Content("Las misiones no estan disponibles de 00:00 a 08:00.");
            }
            return View(listaMisiones);
        }
        /// <summary>
        /// meustra los detalles de una mision coje por parametro el id de la mision
        /// </summary>
        /// <param name="id"></param>
        /// <returns>devuelve los detales de una mision en una vita</returns>
        [HttpPost]
        public IActionResult Detalles(int id)
        {

            try
            {
                mision = clsListadoMisionesBL.ObtenerMisionBL(id);
            }
            catch (Exception ex) 
            {
                return Content("Se ha producdo un error.");
            }
            if (mision == null)
            {
                return Content("Las misiones no estan disponibles de 00:00 a 08:00.");
            }

            return View(mision);
        }
    }


}
