using System;
using System.Collections.Generic;

namespace Ejemplo1.Models;

public partial class Invoice
{
    public int InvoiceId { get; set; }

    public int ClientId { get; set; }

    public DateTime? Date { get; set; }

    public decimal Total { get; set; }

    public virtual Client Client { get; set; } = null!;

    public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; } = new List<InvoiceDetail>();
}
