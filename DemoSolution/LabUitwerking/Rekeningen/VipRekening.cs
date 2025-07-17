using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabUitwerking.Rekeningen;

public class VipRekening : IRekening
{

    public string Owner { get; set; }
    public int Balance { get; set; }
    public decimal Discount { get; set; }
    private readonly IKortingService _kortingService;

    public VipRekening(IKortingService kortingService)
    {
        _kortingService = kortingService;
    }

    public void Deposit(int amount)
    {
        Balance += amount;
    }

    public void Withdraw(int amount)
    {
        var fatsoenlijkAmount = _kortingService.GeefKortingBedrag(amount, Discount);
        Console.WriteLine("-- met korting! " + fatsoenlijkAmount);
        Balance -= fatsoenlijkAmount;
    }
}
