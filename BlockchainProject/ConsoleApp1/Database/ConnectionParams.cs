﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Database
{
    public class ConnectionParams
    {
        public static readonly string LOCAL_DATA_SOURCE = "//localhost:1521/NoblicaDB";
        public static readonly string CLASSROOM_DATA_SOURCE = "//192.168.0.102:1522/db2016";

        public static readonly string USER_ID = "ERS";
        public static readonly string PASSWORD = "noblica";
    }
}
