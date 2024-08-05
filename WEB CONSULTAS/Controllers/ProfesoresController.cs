using Microsoft.Ajax.Utilities;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;
using WEB_CONSULTAS.ProxyConsultas;
using WEB_CONSULTAS.ProxyProfesor;

namespace WEB_CONSULTAS.Controllers
{
    public class ProfesoresController : Controller
    {


        // INTANCIAMOS SERVICIO DE PROFESORES
        ServicioProfesorClient servicioProfesorClient = new ServicioProfesorClient();

        // INSTANCIAMOS SERVICIO DE CONSULTAS
        ServicioConsultasClient servicioConsultasClient = new ServicioConsultasClient();

        // obtenemos la lista de especialidades para filtrarlas
        public List<SelectListItem> obtenerEspecialidades(String especialidad)
        {
            // btener la lista de especialidades y agrupar por el nombre de la especialidad para eliminar duplicados
            // Obtener la lista de especialidades y agrupar por el nombre de la especialidad para eliminar duplicados
            var especialidades = servicioProfesorClient.ListarProfesor()
                .GroupBy(p => p.ESPECIALIDAD)
                .Select(g => g.First())
                .Select(p => new SelectListItem
                {
                    Text = p.ESPECIALIDAD,
                    Value = p.ESPECIALIDAD
                })
                .ToList();

            // Agregar el elemento por defecto al inicio de la lista
            especialidades.Insert(0, new SelectListItem
            {
                Text = "Seleccione especialidad",
                Value = "0"
            });

            // Seleccionar la especialidad que coincida con el parámetro proporcionado
            var especialidadSeleccionada = especialidades.FirstOrDefault(x => x.Value == especialidad);

            if (especialidadSeleccionada != null)
            {
                especialidadSeleccionada.Selected = true;
            }

            return especialidades;
        }

        // GET: Profesores
        public ActionResult Index(int? page)
        {
            ViewBag.ListarEspecialidad = obtenerEspecialidades("0");

            var profesores = servicioProfesorClient.ListarProfesor();

            int pageSize = 10;

            int numberPage = (page ?? 1);

            var pagedList = profesores.ToPagedList(numberPage, pageSize);

            ViewBag.PagedList = pagedList;

            return View(ViewBag.PagedList);
        }

        // buscar porfesor por especialidad
        public ActionResult Buscar(FormCollection fc)
        {
            // guardamos los criterios de busqueda
            String strEspecialidad = fc["especialidad"];

            if (strEspecialidad != "0")
            {

                return RedirectToAction("Especialidad", new { especialidad = strEspecialidad });

            }

            return RedirectToAction("Index");

        }

        // profesores por especidalidades 
        public ActionResult Especialidad (int? page, string especialidad) {
            if(especialidad.IsNullOrWhiteSpace())
            {
                return RedirectToAction("Index");
            }

            ViewBag.ListarEspecialidad = obtenerEspecialidades(especialidad);

            var profesores = servicioConsultasClient.ConsultarProfesoresPorEspecialidad(especialidad);

            int pageSize = 10;

            int numberPage = (page ?? 1);

            var pagedList = profesores.ToPagedList(numberPage, pageSize);

            ViewBag.PagedList = pagedList;

            return View(ViewBag.PagedList);
        }


    }
}