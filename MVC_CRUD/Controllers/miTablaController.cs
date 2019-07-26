using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_CRUD.Models;
using MVC_CRUD.Models.ViewModels;

namespace MVC_CRUD.Controllers
{
    public class miTablaController : Controller
    {
        // GET: miTabla
        public ActionResult Index()
        {
            List<ListTablaViewModel> lst;
            using (miBaseDatosEntities2 db = new miBaseDatosEntities2())
            {
                lst=(from d in db.miTabla
                        select new ListTablaViewModel
                        {
                            Id=d.id,
                            Nombre=d.nombre,
                            Correo = d.correo,
                           
                           
                            
                        }).ToList();
            }
            return View(lst);
        }
    }
}