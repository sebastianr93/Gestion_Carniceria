using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Carniceria.Entities
{
    public class Categoria
    {
        public int ID { get; set; }
        public string Nombre { get; set; }

        // Validar el tipo para que solo sea "peso" o "cantidad"
        private string tipo;
        public string Tipo
        {
            get { return tipo; }
            set
            {
                if (value == "peso" || value == "cantidad")
                {
                    tipo = value;
                }
                else
                {
                    throw new ArgumentException("El tipo debe ser 'peso' o 'cantidad'.");
                }
            }
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
