using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy.BlockerContent
{
    public interface IBlocker
    {
        public bool IsSituable(int age);
    }
}
