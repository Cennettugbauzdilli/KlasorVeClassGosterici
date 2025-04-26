using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasorVeClassGosterici
{
    [Aciklama("EFT yöntemi ile ödeme yapılır.")]
    public class EFT : IOdemeYontemi
    {
        public string Ode(decimal tutar)
        {
            return $"EFT ile {tutar:C} ödendi.";
        }
    }

}
