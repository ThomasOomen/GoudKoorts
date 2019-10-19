using System;
using System.Collections.Generic;
using System.Text;

namespace Goudkoorts
{
    public class SwitchTrack : SimpleTrack
    {
        public SwitchTrack(Direction inDirection, Direction outDirection) : base(inDirection, outDirection)
        {
            this._InDirection = inDirection;
            this._OutDirection = outDirection;
        }

        public void SwitchDirection()
        {
            if (this._OutDirection == Direction.East)
            {
                this._OutDirection = Direction.West;
            }
            else if (this._OutDirection == Direction.West)
            {
                this._OutDirection = Direction.East;
            }
            else if (this._OutDirection == Direction.North)
            {
                this._OutDirection = Direction.South;
            }
            else
            {
                this._OutDirection = Direction.North;
            }
        }

    }
}