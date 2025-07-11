using Gestion_Carniceria.Entities;
using System;

public class Venta
{
    public int ID { get; set; }
    public DateTime Fecha { get; set; }
    public string FormatoPago { get; set; }
    public decimal ValorTotal { get; set; }
    public decimal PagoParcial { get; set; }
    public Cliente Cliente { get; set; }
    public List<ItemVenta> Items { get; set; } = new List<ItemVenta>();
}

