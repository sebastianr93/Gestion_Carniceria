using Gestion_Carniceria.Entities;
using System;

public enum TipoProducto
{
    Unidad,
    Peso
}

public class Producto : ICloneable
{
    public int ID { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public decimal Precio { get; set; }

    public decimal PrecioCosto { get; set; } // nueva propiedad
    public decimal Peso { get; set; }
    public int Cantidad { get; set; }
    public TipoProducto Tipo { get; set; }
    public Categoria Categoria { get; set; }

    public int CategoriaID
    {
        get { return Categoria != null ? Categoria.ID : 0; }
        set
        {
            if (Categoria == null)
                Categoria = new Categoria();

            Categoria.ID = value;
        }
    }

    public string CategoriaNombre
    {
        get { return Categoria != null ? Categoria.Nombre : "(Sin categoría)"; }
    }

    public void AgregarStock(int cantidad) => Cantidad += cantidad;

    public object Clone()
    {
        return new Producto
        {
            ID = this.ID,
            Nombre = this.Nombre,
            Descripcion = this.Descripcion,
            Precio = this.Precio,
            PrecioCosto = this.PrecioCosto, // <- esto faltaba
            Cantidad = this.Cantidad,
            Peso = this.Peso,
            Tipo = this.Tipo,
            Categoria = this.Categoria
        };
    }

    public void RestarStock(int cantidad) => Cantidad -= cantidad;
}

