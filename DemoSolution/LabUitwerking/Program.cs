using LabUitwerking.Rekeningen;

namespace LabUitwerking;

internal class Program
{
    static void Main(string[] args)
    {
        var rabo = new Bank();
        var jp = rabo.OpenAccount("JP", 169403, Rekeningsoort.VipRekening);
        var sneder = rabo.OpenAccount("Sneder", 1130, Rekeningsoort.Spaarrekening);

        rabo.TransferMoney(jp, sneder, 2000);

        Console.WriteLine($"JP balans: {jp.Balance}");
        Console.WriteLine($"sneder balans: {sneder.Balance}");
    }
}
