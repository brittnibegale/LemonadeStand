﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public abstract class Item
    {
        
        public Item()
        {
        }
        public abstract int GetItemBoughtAmount();
       
    }
}
