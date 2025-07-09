using LabUitwerking.Rekeningen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabUitwerking;

public class Bank
{
    private List<IRekening> _accounts = [];

    public IRekening OpenAccount(string owner, int initialBalance, Rekeningsoort soort)
    {
        IRekening newRekening;
        if (soort == Rekeningsoort.LopendeRekening)
        {
            newRekening = new LopendeRekening { Owner = owner, Balance = initialBalance };
        }
        else if (soort == Rekeningsoort.Spaarrekening)
        {
            newRekening = new Spaarrekening { Owner = owner, Balance = initialBalance };
        }
        else if (soort == Rekeningsoort.VipRekening)
        {
            newRekening = new VipRekening { Owner = owner, Balance = initialBalance, Discount = 12.1m };
        }
        else
        {
            throw new NotSupportedException();
        }

        _accounts.Add(newRekening);
        return newRekening;
    }

    public void TransferMoney(IRekening from, IRekening to, int amount)
    {
        from.Withdraw(amount);
        to.Deposit(amount);
    }
}
