﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    [Serializable]
    internal class Good
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public float Sale { get; set; }
        public string Description { get; set; }
        
    }
}

