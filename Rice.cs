﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invent3
{
    public class Rice
    {


     
        public List<TypeofRice> typeofRice;
        public List<TypeofPules> typeofPules;
        public List<TypeofWheats> typeofWheats;
    }

    public class TypeofRice
    {
        public string name;
        public int weight;
        public int price;

    }
    public class TypeofPules
    {
        public string name;
        public int weight;
        public int price;

    }
    public class TypeofWheats
    {
        public string name;
        public int weight;
        public int price;
    }

}


