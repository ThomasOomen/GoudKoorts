using System;
using System.Collections.Generic;
using System.Text;

namespace Goudkoorts
{
    public class MarshallYard : SimpleTrack
    {
        public MarshallYard(Direction inDirection, Direction outDirection, ConsoleColor color) : base(inDirection, outDirection)
        {
            this._InDirection = inDirection;
            this._OutDirection = outDirection;
            this.ForegroundColor = color;
            this.BackgroundColor = ConsoleColor.Black;
        }

        protected override MoveableObject _Object { get; set; }


    }
}