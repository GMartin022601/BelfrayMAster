using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belfray
{
    class Globals
    {
        public static string prdNoSel = "";

        public static string bookNoSel = "";

        public static bool firstLoad = true;

        public static string rowSel = "";

        public static string[] rooms = new string[19] { " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "};

        public static int[] capacity = new int[19] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
    }
}
