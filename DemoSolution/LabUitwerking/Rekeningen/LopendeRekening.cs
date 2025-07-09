using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabUitwerking.Rekeningen;

internal class LopendeRekening : IRekening
{
    public string Owner { get; set; }
    public int Balance { get; set; }

    public void Deposit(int amount)
    {
        Balance += amount;
    }

    public void Withdraw(int amount)
    {
        Balance -= amount;
    }
}
