﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_shop
{
    class Posters : Product
    {
        public Posters(string name, double price, string Desc)
        {
            productName = name;
            productPrice = price;
            shortDescription = Desc;
            //  SourceImage = source;
        }
    }
}
