using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicsApi
{
    public class Connections : EconomicsConnector
    {

        public Connections(string tokenOne, string tokenTwo) : base(tokenOne, tokenTwo)
        {}

    }
}
