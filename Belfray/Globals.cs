﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belfray
{
    class Globals
    {
        public static string prdNoSel = "";

        public static string ProdNumber
        {
            get
            {
                return prdNoSel;
            }
            set
            {
                prdNoSel = value;
            }
        }

    }
}
