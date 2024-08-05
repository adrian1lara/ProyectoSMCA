using Microsoft.Ajax.Utilities;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB_CONSULTAS.ProxyConsultas;

namespace WEB_CONSULTAS.Controllers
{
    public class SeccionesController : Controller
    {
        // instanciamos el servicio de consultas
        ServicioConsultasClient servicioConsultasClient = new ServicioConsultasClient();
        // GET: Secciones
        public ActionResult Index(int? page, String codigo)
        {
            

            IEnumerable<SeccionDC> secciones = string.IsNullOrWhiteSpace(codigo)
               ? servicioConsultasClient.ConsultarSeccionesPorProfesorId("")
               : servicioConsultasClient.ConsultarSeccionesPorProfesorId(codigo);

            int pageSize = 10;
            int pageNumber = (page ?? 1);

            // Convertir la lista de secciones a una lista paginada
            IPagedList<SeccionDC> pagedList = secciones.ToPagedList(pageNumber, pageSize);

            return View(pagedList);

          
        }


        public ActionResult Buscar(string codigo)
        {

            if (!string.IsNullOrWhiteSpace(codigo))
            {
                // Redirigir a la acción Index con el código de profesor como parámetro
                return RedirectToAction("Index", new { codigo });
            }

            // Si no se proporciona un código válido, volver a cargar la vista Index sin filtro
            return RedirectToAction("Index");
        }
    
    }
}