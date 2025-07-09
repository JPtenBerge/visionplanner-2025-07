using LabUitwerking.Rekeningen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabUitwerking;

public class Bank
{
    private List<Rekening> _accounts = [];

    public Rekening OpenAccount(string owner, int initialBalance, Rekeningsoort soort)
    {
        Rekening newRekening;
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

    public void TransferMoney(Rekening from, Rekening to, int amount)
    {
        from.Withdraw(amount);
        to.Deposit(amount);
    }
}
