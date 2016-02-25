﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Figures
{
    public class Bishop:Figure
    {
        public Bishop(char x, int y, bool isWhite): base(x, y, isWhite)
        {

        }
        public override void Move(char x, int y)
        {
            if (!this.FigureChangePosition(x,y))
            {
                throw new ArgumentException("You should move to a diffrent positon");
            }
            int xDiff = this.Xpositon - x;
            int yDiff = this.Ypositon - y;
            if (xDiff<0)
            {
                xDiff = xDiff * -1;
            }
            if (yDiff < 0)
            {
                yDiff = yDiff * -1;
            }    
            if(xDiff==yDiff)
            {
                this.Xpositon = x;
                this.Ypositon = y;
            }
            else
            {
                throw new ArgumentException("Invalid bishop coordinates");
            }
        }
    }
}
