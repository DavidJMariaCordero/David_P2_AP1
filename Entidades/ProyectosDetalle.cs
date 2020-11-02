using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace David_P2_AP1.Entidades
{
    public class ProyectosDetalle
    {
        [Key]
        public int IdDetalle { get; set; }
        public int TipoId { get; set; }
        public int ProyectoId { get; set; }
        public string Requerimientos { get; set; }
        public int Tiempo { get; set; }
    }
}
