using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabUitwerking.Rekeningen;

internal class VipRekening : Rekening
{
    public decimal Discount { get; set; }

    public override void Withdraw(int amount)
    {
        var discountAmount = amount / 100 * Discount;
        var discountedAmount = amount - discountAmount;
        var fatsoenlijkAmount = Convert.ToInt32(discountedAmount);
        Console.WriteLine("-- met korting! " + fatsoenlijkAmount);
        base.Withdraw(fatsoenlijkAmount);
    }
}
