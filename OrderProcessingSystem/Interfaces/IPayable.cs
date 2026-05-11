using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingSystem.Interfaces
{
    public interface IPayable
    {
        string Pay(decimal amount);
    }
}
