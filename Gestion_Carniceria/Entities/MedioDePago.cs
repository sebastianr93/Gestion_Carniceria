using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Carniceria.Entities
{
    public class MedioDePago
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int PorcentajeAjuste { get; set; } // entero: -100 a 100

        public static List<MedioDePago> ObtenerMediosPorDefecto()
        {
            return new List<MedioDePago>
        {
            new MedioDePago { Nombre = "Efectivo", PorcentajeAjuste = 0 },
            new MedioDePago { Nombre = "Tarjeta de crédito", PorcentajeAjuste = 0 },
            new MedioDePago { Nombre = "Débito", PorcentajeAjuste = 0 }
        };
        }

        public override string ToString() => Nombre;
    }

}
