using System;

public class Proveedor
{
    public int ID { get; set; }
    public string Nombre { get; set; }
    public string Telefono { get; set; }
    public string Correo { get; set; }
    public string Descripcion { get; set; }
    public decimal CuentaCorriente { get; set; }

    public void AgregarAlaCuentaCorriente(decimal valor) => CuentaCorriente += valor;
    public void PagarCuentaCorriente(decimal valor) => CuentaCorriente -= valor;
}

