using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibreria;

public class Invoice
{
    public virtual double GetInvoiceDiscount(double amount)
    {
        return amount * 0.1;
    }
}

public class FinalInvoice : Invoice
{
    public override double GetInvoiceDiscount(double amount)
    {
        return amount * 0.2;
    }
}

public class ProposedInvoice : Invoice
{
    public override double GetInvoiceDiscount(double amount)
    {
        return amount * 0.3;
    }
}
