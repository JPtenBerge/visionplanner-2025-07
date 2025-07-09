using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabUitwerking.Rekeningen;

internal class VipRekening : IRekening
{
    public string Owner { get; set; }
    public int Balance { get; set; }
    public decimal Discount { get; set; }

    public void Deposit(int amount)
    {
        Balance += amount;
    }

    public void Withdraw(int amount)
    {
        var discountAmount = amount / 100 * Discount;
        var discountedAmount = amount - discountAmount;
        var fatsoenlijkAmount = Convert.ToInt32(discountedAmount);
        Console.WriteLine("-- met korting! " + fatsoenlijkAmount);
        Balance -= fatsoenlijkAmount;
    }
}
