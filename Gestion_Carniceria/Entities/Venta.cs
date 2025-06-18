using System;

public class Venta
{
    public int ID { get; set; }
    public DateTime Fecha { get; set; }
    public string FormatoPago { get; set; }
    public decimal ValorTotal { get; set; }
    public Cliente Cliente { get; set; }
    public List<Producto> ProductosVendidos { get; set; } = new List<Producto>();
}

