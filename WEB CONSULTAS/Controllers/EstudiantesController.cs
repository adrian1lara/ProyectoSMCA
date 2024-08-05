using Microsoft.Ajax.Utilities;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB_CONSULTAS.ProxyConsultas;
using WEB_CONSULTAS.ProxyEstudiante;

namespace WEB_CONSULTAS.Controllers
{
    public class EstudiantesController : Controller
    {
        //instanciamos el servicio de estudiantes
        ServicioEstudianteClient servicioEstudianteClient = new ServicioEstudianteClient();

        // instanciamos el servicio de consultas
        ServicioConsultasClient servicioConsultasClient = new ServicioConsultasClient();


        // GET: Estudiantes
        public ActionResult Index(int? page)
        {

            ViewBag.ListarGrado = obetenerGrados("0");

            // listamos estudiantes y los alamacenamose en variable
            var estudiantes = servicioEstudianteClient.ListarEstudiante();

            int pageSize = 10;

            // si la pagina es un null, el default 1
            int pageNumber = (page ?? 1);

            var pagedList = estudiantes.ToPagedList(pageNumber, pageSize);


            return View(pagedList);
        }

        public List<SelectListItem> obetenerGrados(string grado)
        {
            // creamos y obtenemos el valor
            List<SelectListItem> grados = new List<SelectListItem>
            {
                new SelectListItem { Value = "0", Text = "Selecciona grado" },
                new SelectListItem { Value = "1", Text = "1 grado" },
                new SelectListItem { Value = "2", Text = "2 grado" },
                new SelectListItem { Value = "3", Text = "3 grado" },
                new SelectListItem { Value = "4", Text = "4 grado" },
                new SelectListItem { Value = "5", Text = "5 grado" },
                new SelectListItem { Value = "6", Text = "6 grado" },
                new SelectListItem { Value = "7", Text = "Inicial" }
            };

            SelectListItem gradoSeleccionado = new SelectListItem();

            gradoSeleccionado = grados.Where(x => x.Value == grado).FirstOrDefault();

            gradoSeleccionado.Selected = true;

            return grados;

        }
        
        // mostrar estudiantes por grado
        public ActionResult Grados(int? page, string grado)
        {
            if(grado.IsNullOrWhiteSpace())
            {
                return RedirectToAction("Index");
            }

            ViewBag.ListarGrado = obetenerGrados(grado);

            int gradoInt = int.Parse(grado);

            ViewBag.grado = grado;

            var estudiantes = servicioConsultasClient.ConsultarEstudiantesPorGradoId(gradoInt);

            int pageSize = 10;

            // si la pagina es un null, el default 1
            int pageNumber = (page ?? 1);

            var pagedList = estudiantes.ToPagedList(pageNumber, pageSize);

            return View(pagedList);
           
        }


        //bucar grado

        public ActionResult Buscar (FormCollection fc)
        {
            String strGrado = fc["grado"];

            if(strGrado != "0")
            {
                return RedirectToAction("Grados", new { grado = strGrado });
            }

            return RedirectToAction("Index");
        }
    }
}