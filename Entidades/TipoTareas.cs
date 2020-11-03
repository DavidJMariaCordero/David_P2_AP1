using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace David_P2_AP1.Entidades
{
    public class TipoTareas
    {
        [Key]
        public int TipoId { get; set; }
        public string Descripcion { get; set; }

        public TipoTareas() { }
    }
}
