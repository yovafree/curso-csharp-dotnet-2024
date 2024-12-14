using Ejemplo1.Models;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        var db = new DbTestContext();

        var clients = db.Clients.Include(client => client.Invoices);

        // clients.Where(client => client.Name == "John Doe").ToList();

        foreach (var client in clients)
        {
            Console.WriteLine($"Client: {client.Name}");
            client.Invoices.ToList().ForEach(invoice => Console.WriteLine($"Invoice: {invoice.InvoiceId}"));
        }

        // Mostrar una factura con sus detalles y nombres de productos
        var invoices = db.Invoices
        .Include(invoice => invoice.InvoiceDetails)
        .ThenInclude(detail => detail.Product)
        .ToList();

        foreach (var invoice in invoices)
        {
            Console.WriteLine($"Invoice: {invoice.InvoiceId}");
            invoice.InvoiceDetails
            .ToList()
            .ForEach(detail => Console.WriteLine($"Product: {detail.Product.Name}"));
        }
    }
}