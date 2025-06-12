using System;

public static class Informe
{
    public static decimal CalcularCierreDelDia(List<Venta> ventas, DateTime fecha)
    {
        return ventas
            .Where(v => v.Fecha.Date == fecha.Date)
            .Sum(v => v.ValorTotal);
    }

    public static List<Cliente> ObtenerClientesConDeuda(List<Cliente> clientes)
    {
        return clientes.Where(c => c.Deuda > 0).ToList();
    }

    public static decimal CalcularTotalesPorPeriodo(List<Venta> ventas, DateTime desde, DateTime hasta)
    {
        return ventas
            .Where(v => v.Fecha.Date >= desde && v.Fecha.Date <= hasta)
            .Sum(v => v.ValorTotal);
    }

    public static List<Cliente> RankingDeClientes(List<Venta> ventas)
    {
        return ventas
            .GroupBy(v => v.Cliente)
            .OrderByDescending(g => g.Sum(v => v.ValorTotal))
            .Select(g => g.Key)
            .ToList();
    }
}


