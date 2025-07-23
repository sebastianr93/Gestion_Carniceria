using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Carniceria.Entities
{
    public class Pedido
    {
        public int ID { get; set; }
        public DateTime Fecha { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal PagoParcial { get; set; }
        public Proveedor Proveedor { get; set; }
        public List<ItemPedido> Items { get; set; }
    }

}
