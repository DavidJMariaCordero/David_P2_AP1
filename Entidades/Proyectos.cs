using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Windows;

namespace David_P2_AP1.Entidades
{
    public class Proyectos
    {
        [Key]
        public int ProyectoId { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public int Tiempo { get; set; }

        [ForeignKey("ProyectoId")]
        public List<ProyectosDetalle> Detalle { get; set; } = new List<ProyectosDetalle>();
    }
}
