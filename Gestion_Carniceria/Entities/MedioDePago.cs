using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Carniceria.Entities
{
    public class MedioDePago
    {
        public string Nombre { get; set; }
        public decimal PorcentajeAjuste { get; set; } // Porcentaje de ajuste de recargo o descuento

        // Método estático que devuelve los medios de pago por defecto
        public static List<MedioDePago> ObtenerMediosPorDefecto()
        {
            return new List<MedioDePago>
        {
            new MedioDePago { Nombre = "Efectivo", PorcentajeAjuste = 0 },
            new MedioDePago { Nombre = "Tarjeta de crédito", PorcentajeAjuste = 0 },
            new MedioDePago { Nombre = "Débito", PorcentajeAjuste = 0 }
        };
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
