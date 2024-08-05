using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//agregamos los proxys
using WEB_CONSULTAS.ProxyMatricula;

// agregamos el util de la paginacion
using PagedList;
using Microsoft.Ajax.Utilities;
using WEB_CONSULTAS.ProxyConsultas;

namespace WEB_CONSULTAS.Controllers
{
    public class MatriculasController : Controller
    {
        // instanciamos el servicio de matriculas
        ServicioMatriculaClient servicioMatriculaClient = new ServicioMatriculaClient();

        //instanciamos el servicio de consultas
        ServicioConsultasClient servicioConsultasClient = new ServicioConsultasClient();
        // GET: Matriculas
        public ActionResult Index(int? page)
        {
            // alamacenamos la lista de matriculas en una variable
            var matriculas = servicioMatriculaClient.ListarMatricula();

            // numero de registros por pagina
            int pageSize = 10;

            // si la pagina es null, el default es 1
            int pageNumber = (page ?? 1);

            var pagedList = matriculas.ToPagedList(pageNumber, pageSize);

            return View(pagedList);
        }

        // mostramos la martricula encontrada
        public ActionResult DNI(String dni)
        {
            if(dni.IsNullOrWhiteSpace())
            {
                return RedirectToAction("Index");
            }
            
            int dniInt = int.Parse(dni);

            var matricula = servicioConsultasClient.ConsultarMatriculaPorAlumnoDNI(dniInt);

            ViewBag.matricula = matricula; 

            return View();
        }

        // mostrar matriculas por fechas
        public ActionResult Fechas(int? page, string startDate, string endDate)
        {
            if (string.IsNullOrWhiteSpace(startDate) || string.IsNullOrWhiteSpace(endDate))
            {
                return RedirectToAction("Index");
            }

            DateTime defaultStartDate = DateTime.Now.AddYears(-2);
            DateTime defaultEndDate = DateTime.Now;

            DateTime startDateNew;
            DateTime endDateNew;

            // Intentar convertir las fechas de cadena a DateTime
            if (!DateTime.TryParse(startDate, out startDateNew))
            {
                startDateNew = defaultStartDate;
            }

            if (!DateTime.TryParse(endDate, out endDateNew))
            {
                endDateNew = defaultEndDate;
            }

            ViewBag.DefaultStartDate = startDateNew;
            ViewBag.DefaultEndDate = endDateNew;

            var matriculas = servicioConsultasClient.ConsultarMatriculadosPorFechas(startDateNew, endDateNew);

            int pageSize = 10;
            int pageNumber = (page ?? 1);

            var pagedList = matriculas.ToPagedList(pageNumber, pageSize);

            return View(pagedList);

        }

        public ActionResult BuscarFechas(string startDate, string endDate)
        {

            if (!string.IsNullOrEmpty(startDate) || !string.IsNullOrEmpty(endDate))
            {
                return RedirectToAction("Fechas", new {startDate, endDate});
            }

            return RedirectToAction("Index");
        }



        // Buscar matricula por dni
        public ActionResult Buscar(String dni)
        {
            if(!string.IsNullOrWhiteSpace(dni))
            {
                return RedirectToAction("DNI", new {dni});
            }

            return RedirectToAction("Index"); 
        }
    }
}