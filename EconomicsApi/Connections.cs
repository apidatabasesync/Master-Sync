using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This class is for our login autenfication and extends abstract class

namespace EconomicsApi
{
    public class Connections : EconomicsConnector
    {

        public Connections(string tokenOne, string tokenTwo) : base(tokenOne, tokenTwo)
        {}

    }
}
