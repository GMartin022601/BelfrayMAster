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

        public static string bookSel = "";

        public static string tableSel = "";

        public static string bookNoSel = "";

        public static string itemSel = "";

        public static int roomNoSel = 0;

        public static bool firstLoad = true;

        public static string rowSel = "";

        //Tracks Rooms Added on the Booking Add Form
        public static string[] rooms = new string[19] { " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "};

        //tracks Rooms Deleted on the Booking Deit Form
        public static string[] delRooms = new string[19] { " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " " };

        public static string[] removedRooms = new string[19] { " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " " };

        public static string[] tables = new string[23] { " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " " };

        public static int[] capacity = new int[19] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

        public static int[] tableCapac = new int[23] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static bool dateChange = true;

        public static bool roomLoad = true;

        public static DateTime checkInDate = new DateTime();

        public static DateTime checkOutDate = new DateTime();

        public static string staffNo = "";
    }
}
