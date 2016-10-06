using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Economic Developers class

namespace EconomicsApi
{
    public abstract class EconomicsConnector : IDisposable
    {
        public EconSoapLibrary.EconApi.EconomicWebServiceSoapClient session = null;
        private bool disposed;
        private readonly string tokenOne = string.Empty;
        private readonly string tokenTwo = string.Empty;

        protected EconomicsConnector(string tokenOne, string tokenTwo) {

            this.tokenOne = tokenOne;
            this.tokenTwo = tokenTwo;
            session = new EconSoapLibrary.EconApi.EconomicWebServiceSoapClient();
            Connected();
        }

        private void Connected()
        {
            session.ConnectWithToken(this.tokenOne, this.tokenTwo);
        }

        public void Dispose()
        {

            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposed)
        {
            if (disposed) return;

            session.Disconnect();
            disposed = true;
        }

        ~EconomicsConnector()
        {
            Dispose(false);
        }

    }
}
