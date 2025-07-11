using Gestion_Carniceria.Entities;
using System;

public enum TipoProducto
{
    Unidad,
    Peso
}

public class Producto
{
    public int ID { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public decimal Precio { get; set; }
    public decimal Peso { get; set; }
    public int Cantidad { get; set; }
    public TipoProducto Tipo { get; set; }
    public Categoria Categoria { get; set; }

    public string CategoriaNombre
    {
        get { return Categoria != null ? Categoria.Nombre : "(Sin categoría)"; }
    }

    public void AgregarStock(int cantidad) => Cantidad += cantidad;
    public void RestarStock(int cantidad) => Cantidad -= cantidad;
}

