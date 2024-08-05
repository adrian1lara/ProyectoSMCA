using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB_CONSULTAS.ProxyCurso;

namespace WEB_CONSULTAS.Controllers
{
    public class CursosController : Controller
    {
        // instanciamos el servicio de curso
        ServicioCursoClient servicioCursoClient = new ServicioCursoClient();

        // GET: Cursos
        public ActionResult Index(int? page)
        {
            // almacenamos la lista de matgriculas en una variable
            var cursos = servicioCursoClient.ListarCurso();

            // numero de registros por pagina
            int pagerSize = 10;

            // si la pagina es null, asignamos el valor 1
            int pageNumber = (page ?? 1);

            var pagedList = cursos.ToPagedList(pageNumber, pagerSize);

            return View(pagedList);
        }
    }
}