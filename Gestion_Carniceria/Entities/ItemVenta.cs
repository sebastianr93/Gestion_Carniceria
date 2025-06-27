using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Carniceria.Entities
{
    public class ItemVenta
    {
        public Producto Producto { get; set; }
        public decimal Cantidad { get; set; }

        public decimal PrecioUnitario => Producto?.Precio ?? 0;
        public decimal Subtotal => PrecioUnitario * Cantidad;
        public string ProductoNombre => Producto?.Nombre ?? "";
        public string ProductoTipo => Producto?.Tipo.ToString() ?? "";
    }

}
