using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabUitwerking;

public class Bank
{
    private List<Rekening> _accounts = [];

    public Rekening OpenAccount(string owner, int initialBalance)
    {
        var newRekening = new Rekening { Owner = owner, Balance = initialBalance };
        _accounts.Add(newRekening);
        return newRekening;
    }

    public void TransferMoney(Rekening from, Rekening to, int amount)
    {
        from.Withdraw(amount);
        to.Deposit(amount);
    }
}
