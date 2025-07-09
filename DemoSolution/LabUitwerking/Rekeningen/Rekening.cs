using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabUitwerking.Rekeningen;

public class Rekening
{
    public string Owner { get; set; }
    public int Balance { get; set; }

    public virtual void Deposit(int amount)
    {
        Balance += amount;
    }

    public virtual void Withdraw(int amount)
    {
        Balance -= amount;
    }
}
