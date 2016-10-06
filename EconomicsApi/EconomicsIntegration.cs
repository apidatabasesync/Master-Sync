using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EconSoapLibrary.EconApi;

namespace EconomicsApi
{
    class EconomicsIntegration : EconomicsConnector
    {
        public EconomicsIntegration(string tokenOne, string tokenTwo) : base(tokenOne, tokenTwo)
        { }

        public DebtorHandle[] Debtor_GetAllData()
        {
            return this.session.Debtor_GetAll();
          
        }
    }
}
