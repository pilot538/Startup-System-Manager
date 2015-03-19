using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Threading;

namespace Startup_Program
{
    static class Program
    {
     

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

       
          
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ManagerInSystemTrayForm());
       
        }

        /// <summary>   
        /// For speaking
        /// </summary>
        /// <param name="speech">What to say</param>
        
    }
}