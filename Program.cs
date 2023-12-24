using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicktingApplication
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new LandingPage());









            //Application.Run(new RemoveTicket());
            // Application.Run(new UpdateFlight2());

            //Application.Run(new ViewTicket());
            // Application.Run(new AddNewTicket());
           // Application.Run(new UserBuyTicket());
            //Application.Run(new AdminHome();
            //Application.Run(new UserHome());

            // Application.Run(new AdminViewCancledTicket());

            //Application.Run(new UserAvaliableFlight());
          //  Application.Run(new Login());
            //Application.Run(new AddPassenger());
            //Application.Run(new ViewPassenger());
        }
    }
}
