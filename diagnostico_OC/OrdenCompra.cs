using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diagnostico_OC
{
    internal class OrdenCompra
    {
        public int Id { get; set; }
        public string Informador { get; set; }
        public string Descripcion { get; set; }
        public string Responsable { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaResolucion { get; set; }
        public Boolean Estado { get; set; }
        public int Prioridad { get; set; }

        public OrdenCompra() { }



    }
}
