using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPISP
{
    public interface IPaymentMethod
    {
        void Pay(decimal amount);
    }
}
