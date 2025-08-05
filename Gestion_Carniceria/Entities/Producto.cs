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
    public decimal Peso { get; set; }
    public int Cantidad { get; set; }
    public TipoProducto Tipo { get; set; }
    public Categoria Categoria { get; set; }

    // Permite obtener o asignar el ID de la categoría directamente
    public int CategoriaID
    {
        get => Categoria != null ? Categoria.ID : 0;
        set
        {
            if (Categoria == null)
                Categoria = new Categoria();
            Categoria.ID = value;
        }
    }

    // Nombre legible de la categoría
    public string CategoriaNombre
    {
        get => Categoria != null ? Categoria.Nombre : "(Sin categoría)";
    }

    public void AgregarStock(int cantidad) => Cantidad += cantidad;

    public void RestarStock(int cantidad) => Cantidad -= cantidad;

    // Implementación de clonación para crear una copia superficial del objeto
    public object Clone()
    {
        return new Producto
        {
            ID = this.ID,
            Nombre = this.Nombre,
            Descripcion = this.Descripcion,
            Precio = this.Precio,
            Cantidad = this.Cantidad,
            Peso = this.Peso,
            Tipo = this.Tipo,
            Categoria = this.Categoria // ojo, copia referencia (shallow copy)
        };
    }
}
