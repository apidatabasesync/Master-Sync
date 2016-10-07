using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EconSoapLibrary.EconApi;

namespace EconomicsApi
{
    class EcoConnect
    {
       
        private readonly string tokenOne = "nfPig4Gnj2shh2D8MnMyu5XRB7KSzBsbDa3MVdv67wI1";
        private readonly string tokenTwo = "g4pVuB04ZM2h4rIBqMtaDSnHSwWuCepy5BhwMK4LCjQ1";

        public EcoConnect()
        {
            var session = new EconSoapLibrary.EconApi.EconomicWebServiceSoapClient();
            session.ConnectWithToken(tokenOne, tokenTwo);
            
        }

      

        public void Discon()
        {
            var session = new EconSoapLibrary.EconApi.EconomicWebServiceSoapClient();
            session.Disconnect();
        }
    }
}
