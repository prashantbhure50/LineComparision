﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparision
{
    public class solution
    {
        int x1, x2, y1, y2;
     public solution (int x1, int x2, int y1, int y2)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;

        }
       public  double Check()
        { 
            double d = Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2));
            return d;
        }
    }
}
