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


namespace EconomicsApi
{
    public partial class emailSync : Form
    {
        public emailSync()
        {
            InitializeComponent();

           
        }

        private void emailSync_Load(object sender, EventArgs e)
        {
            //JiCekRM3yza8AnDJgprYsruI1w9isZnRYpILl3AVbIo1
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //textBox1.Text = "test";

            var session = new EconSoapLibrary.EconApi.EconomicWebServiceSoapClient();
            session.ConnectWithToken("bual5TKRrDC9709Ci71cVKCpkMUpYk33nzlxkIfmnl01", "VFMBs45gNtceuBWMKk8EHnY92KNj6Xye838h8252uQU1");
            var company = session.Company_Get();
            textBox1.Text = company.Number;
            //Console.WriteLine(company.Number);
            session.Disconnect();

            
            
             
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var session2 = new EconSoapLibrary.EconApi.EconomicWebServiceSoapClient();
            session2.ConnectWithToken("bual5TKRrDC9709Ci71cVKCpkMUpYk33nzlxkIfmnl01", "VFMBs45gNtceuBWMKk8EHnY92KNj6Xye838h8252uQU1");
            var name = session2.
            textBox2.Text = name.Length.ToString();
            session2.Disconnect();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
