using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy
{
    public class Image
    {
        private double size;
        private string name;
        public Image(string name, double size)
        {
            this.name = name;
            this.size = size;
        }
    }
}
