using System;

public class Cliente
{
    public int ID { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Telefono { get; set; }
    public string Correo { get; set; }
    public string DNI { get; set; }
    public decimal Deuda { get; set; }

    public void AgregarDeuda(decimal monto) => Deuda += monto;

    public void PagarDeuda(decimal monto)
    {
        Deuda -= monto;
        if (Deuda < 0) Deuda = 0;
    }

    public string NombreCompleto() => $"{Nombre} {Apellido}";
}

