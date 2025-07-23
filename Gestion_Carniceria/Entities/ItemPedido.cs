using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Carniceria.Entities
{
    public class ItemPedido
    {
        public Producto Producto { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }

        public decimal Subtotal => PrecioUnitario * Cantidad;

        // Propiedad para que la grilla muestre el nombre directamente
        public string NombreProducto
        {
            get { return Producto?.Nombre ?? ""; }
        }
    }
}
