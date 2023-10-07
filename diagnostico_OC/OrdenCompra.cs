using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diagnostico_OC
{
    internal class OrdenCompra
    {
        public OrdenCompra(
            int id,
            string informador,
            string descripcion,
            DateTime fechaCreacion,
            string estado,
            int prioridad,
            string responsable="",
            DateTime? fechaResolucion = null
            ) 
        {
            this.Id = id;
            this.Informador = informador;
            this.Descripcion = descripcion; 
            this.FechaCreacion = fechaCreacion;
            this.Estado = estado;   
            this.Prioridad = prioridad;
            this.Responsable = responsable;
            this.FechaResolucion = fechaResolucion;
        }

        public int Id { get; set; }
        public string Informador { get; set; }
        public string Descripcion { get; set; }
        public string Responsable { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaResolucion { get; set; }
        public string Estado { get; set; }
        public int Prioridad { get; set; }

        



    }
}
