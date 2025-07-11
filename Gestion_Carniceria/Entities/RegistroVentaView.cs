using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Carniceria.Entities
{

    //CLASE CREADA PARA MEJORAR LA VISTA DE LAS VENTAS EN EL FORMULARIO FrmRegistroVentas
    public class RegistroVentaView
    {
        public int ID { get; set; }
        public DateTime Fecha { get; set; }
        public string NombreCliente { get; set; }
        public string FormatoPago { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal PagoParcial { get; set; }
    }
}
