using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EconSoapLibrary.EconApi;

//This class cointains the GUI

namespace EconomicsApi
{
    public partial class UserInterface : Form
    {
        public UserInterface()
        {
            InitializeComponent();
            //SoapAPIConnection test = new SoapAPIConnection();
            
            
           
        }

        private void emailSync_Load(object sender, EventArgs e)
        {
            //JiCekRM3yza8AnDJgprYsruI1w9isZnRYpILl3AVbIo1
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //textBox1.Text = "test";
            var session = new EconSoapLibrary.EconApi.EconomicWebServiceSoapClient();
            session.ConnectWithToken("nfPig4Gnj2shh2D8MnMyu5XRB7KSzBsbDa3MVdv67wI1", "g4pVuB04ZM2h4rIBqMtaDSnHSwWuCepy5BhwMK4LCjQ1");
            var company = session.Company_Get();
            textBox1.Text = company.Number;
            session.Disconnect();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //EconomicsIntegration test = new EconomicsIntegration("nfPig4Gnj2shh2D8MnMyu5XRB7KSzBsbDa3MVdv67wI1", "g4pVuB04ZM2h4rIBqMtaDSnHSwWuCepy5BhwMK4LCjQ1");
            var session = new EconSoapLibrary.EconApi.EconomicWebServiceSoapClient();
            session.ConnectWithToken("bual5TKRrDC9709Ci71cVKCpkMUpYk33nzlxkIfmnl01", "VFMBs45gNtceuBWMKk8EHnY92KNj6Xye838h8252uQU1");
            //DebtorHandle[] debtorHandles = session.Debtor_GetAll();
            //var name = session.Debtor_GetEmail(debtorHandles[0]);
            //textBox2.Text = name.Length;
            var test = session.TemplateCollection_GetAll();
            textBox2.Text = test.ToArray<TemplateCollectionHandle>().ToString();
            session.Disconnect();

            //Debtor_GetAll + Debtor_GetDataArray
            //Debtor_GetAllUpdated + Debtor_GetDataArray
            //you can find a list of layout handles by calling TemplateCollection_GetAll.

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
