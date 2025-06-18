using System;

public class Producto
{
    public int ID { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public decimal Peso { get; set; }
    public string Categoria { get; set; }
    public int Cantidad { get; set; }
    public decimal Precio { get; set; }

    public void AgregarStock(int cantidad) => Cantidad += cantidad;
    public void RestarStock(int cantidad) => Cantidad -= cantidad;
}

