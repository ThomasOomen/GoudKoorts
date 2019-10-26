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

        public override Cart _Cart { get; set; }

        public override bool MoveCart()
        {
            var nextTrack = this.TrackInDirection(this._OutDirection);
            if (nextTrack.TrackInDirection(nextTrack._InDirection) == this)
            {
                if (nextTrack.IsEmpty())
                {
                    nextTrack.Add(this._Cart);
                    this.Remove();
                    return true;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
}