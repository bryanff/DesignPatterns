using DesignPatterns.Proxy.BlockerContent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy
{
    class ProxyProgram
    {
        public static void Run()
        {
            AuthService authService = new AuthService();
            IBlocker blocker = new YoungerThanExplicitContentBlocker(18);
            IImageProvider pinterest = new Pinterest();
            IImageProvider proxy = new PinterestCacheProxy(pinterest, authService, blocker);
            proxy.getExplicitImages();
            proxy.getPublicImages();
        }
    }
}
