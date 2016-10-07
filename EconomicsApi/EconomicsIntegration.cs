using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EconSoapLibrary.EconApi;

//This class is going to contain the handles and different query, set, update

namespace EconomicsApi
{
    class EconomicsIntegration : EconomicsConnector
    {
        public EconomicsIntegration(string tokenOne, string tokenTwo) : base(tokenOne, tokenTwo)
        { }

        //returns all Debtors in an array
        public DebtorHandle[] Debtor_GetAllData()
        {
            return this.session.Debtor_GetAll();

        }

    }
}
    