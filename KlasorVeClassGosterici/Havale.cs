using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasorVeClassGosterici
{
    [Aciklama("Havale yöntemi ile ödeme yapılır.")]
    public class Havale : IOdemeYontemi
    {
        public string Ode(decimal tutar)
        {
            return $"Havale ile {tutar:C} ödendi.";
        }
    }

}
