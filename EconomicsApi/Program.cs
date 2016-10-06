using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EconSoapLibrary.EconApi;

//THe main program function

namespace EconomicsApi
{
    static class Program 
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Connections session = new Connections("nfPig4Gnj2shh2D8MnMyu5XRB7KSzBsbDa3MVdv67wI1", "g4pVuB04ZM2h4rIBqMtaDSnHSwWuCepy5BhwMK4LCjQ1");



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UserInterface());
        }
    }

}

