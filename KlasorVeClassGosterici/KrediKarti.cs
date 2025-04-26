using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasorVeClassGosterici
{
    [Aciklama("Kredi kartı ile ödeme yapılır.")]
    public class KrediKarti : IOdemeYontemi
    {
        public string Ode(decimal tutar)
        {
            return $"Kredi kartı ile {tutar:C} ödendi.";
        }
    }

}
