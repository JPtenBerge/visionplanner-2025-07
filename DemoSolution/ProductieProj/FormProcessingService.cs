using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductieProj;

public class FormProcessingService
{
    private readonly IOpslagService _opslagService;
    public FormProcessingService(IOpslagService opslagService)
    {
        _opslagService = opslagService;
    }

    public bool Process(string name, int age, string favoriteBeverage)
    {
        if (favoriteBeverage == null)
        {
            throw new ArgumentNullException(nameof(favoriteBeverage));
        }

        if (age > 120 || age < 0)
        {
            return false;
        }

        _opslagService.Store();
        return true;
    }
}
