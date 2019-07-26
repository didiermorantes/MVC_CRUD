using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_CRUD.Models.ViewModels
{
    public class ListTablaViewModel
    {
        /*representa los elemento */
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public DateTime Fecha { get; set; }

    }
}