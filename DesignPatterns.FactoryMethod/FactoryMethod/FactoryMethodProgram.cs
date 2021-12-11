using DesignPatterns.FactoryMethod.v2;
using DesignPatterns.FactoryMethod.v2.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    public class FactoryMethodProgram
    {
        public static void Run()
        {
            // Parsing V1
            //UserFileParser parserv1 = new UserFileParser();
            //parserv1.getUsers(@"c:/downloads/file.csv");

            //Parsing V2 Applying factory method pattern
            FileParser parser = new XMLFileParser();
            UserParseService parseService = new UserParseService(parser);
            parseService.getUsers(@"c:/downloads/file.xml");
        }
    }
}
