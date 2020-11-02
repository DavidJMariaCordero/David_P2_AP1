using David_P2_AP1.DAL;
using David_P2_AP1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace David_P2_AP1.BLL
{
    public class TipoTareasBLL
    {
        public static List<TipoTareas> GetList() {
            List<TipoTareas>  lista = new List<TipoTareas>();
            Contexto contexto = new Contexto();

            try {
                lista = contexto.TipoTareas.ToList();
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return lista;
        }
    }
}
