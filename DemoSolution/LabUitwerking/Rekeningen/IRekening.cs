using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabUitwerking.Rekeningen;

public interface IRekening
{
    string Owner { get; set; }
    int Balance { get; set; }

    void Deposit(int amount);

    void Withdraw(int amount);
}
