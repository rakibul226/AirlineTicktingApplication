using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicktingApplication
{
    internal class GlobalVariablesClass
    {

        private static string v_VariableOne = "";

        public static string VariableOne
        {
            get { return v_VariableOne; }
            set { v_VariableOne = value; }
        }

    }
}
