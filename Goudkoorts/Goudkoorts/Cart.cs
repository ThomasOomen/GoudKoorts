using System;
using System.Collections.Generic;
using System.Text;

namespace Goudkoorts
{
    public class Cart : MoveableObject
    {
        public Cart()
        {
            HasLoad = true;
        }
        protected override bool Move(Direction direction)
        {
            var nextTrack = this._Track.TrackInDirection(this._Track._OutDirection);
            if (nextTrack.TrackInDirection(nextTrack._InDirection) == this._Track)
            {
                if (nextTrack.IsEmpty())
                {
                    nextTrack.Add(this);
                    this._Track.Remove();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        protected override char ToChar()
        {
            return this._Track.ToChar();
        }

        public override ConsoleColor SetColor()
        {
            if (HasLoad)
            {
                return ConsoleColor.Red;
            }
            else
            {
                return ConsoleColor.Green;
            }
        }
    }
}