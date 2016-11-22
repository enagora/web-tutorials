﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF.B_15_MasterDetailPage
{

    class NamedColor
    {

        public NamedColor(string name, Color color)
        {
            this.Name = name;
            this.Color = color;
        }

        public string Name { private set; get; }
        public Color Color { private set; get; }
        
        public override string ToString()
        {
            return Name;
        }

    }
}
