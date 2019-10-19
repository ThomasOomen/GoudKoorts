using System;
using System.Collections.Generic;
using System.Text;

namespace Goudkoorts
{
    public class MarshallYard : SimpleTrack
    {
        public MarshallYard(Direction inDirection, Direction outDirection) : base(inDirection, outDirection)
        {
            this._InDirection = inDirection;
            this._OutDirection = outDirection;
        }

        protected override MoveableObject _Object { get; set; }


    }
}