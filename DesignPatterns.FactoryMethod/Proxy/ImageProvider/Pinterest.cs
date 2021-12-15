using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy.BlockerContent
{
    public class Pinterest : IImageProvider
    {
        public Dictionary<string, Image> getExplicitImages()
        {
            Dictionary<string, Image> images = new Dictionary<string, Image>();
            images.Add("EC00154", new Image("ExplicitContent1", 2.75));
            images.Add("EC00155", new Image("ExplicitContent2", 3.63));
            images.Add("EC00156", new Image("ExplicitContent3", 8.9));
            return images;
        }
        public Dictionary<string, Image> getPublicImages()
        {
            Dictionary<string, Image> images = new Dictionary<string, Image>();
            images.Add("PC00254", new Image("Granja HD", 2.75));
            images.Add("PC00255", new Image("Perrito cafe", 3.63));
            images.Add("PC00256", new Image("Gatito", 8.9));
            return images;
        }
    }
}
