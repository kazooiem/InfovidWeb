using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InfovidWeb.Models
{
    public class ComunaCLS
    {
        [Display(Name = "ID Comuna")]
        public int idcomuna { get; set; }
        [Display(Name = "Nombre Comuna")]
        public string nombre { get; set; }
        [Display(Name = "Fase Comuna")]
        public int fase { get; set; }
    }
}