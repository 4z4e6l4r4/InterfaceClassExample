﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceClassExample
{
    internal class Product:CommonProperty
    {

        public string Description { get; set; }
        public int Stock { get; set; }
        public int Price { get; set; }

    }
}
