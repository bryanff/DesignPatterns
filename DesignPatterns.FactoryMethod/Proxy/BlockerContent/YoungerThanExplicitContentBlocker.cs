using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy.BlockerContent
{
    public class YoungerThanExplicitContentBlocker : IBlocker
    {
        private readonly int _criteria;
        public YoungerThanExplicitContentBlocker(int criteria) => _criteria = criteria;
        public bool IsSituable(int age) => age >= _criteria;
    }
}
