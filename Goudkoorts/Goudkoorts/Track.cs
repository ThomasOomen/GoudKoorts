using System;
using System.Collections.Generic;
using System.Text;

namespace Goudkoorts
{
    public abstract class Track
    {
        protected Track _North { get; set; }
        protected Track _South { get; set; }
        protected Track _East { get; set; }
        protected Track _West { get; set; }
        protected Direction _OutDirection { get; set; }
        protected Direction _InDirection { get; set; }
        protected abstract MoveableObject _Object { get; set; }
        protected abstract void Remove();
        protected abstract bool Add(MoveableObject Object);
        protected abstract String ObjectToString();


        
        public Track TrackInDirection(Direction direction)
        {
            switch(direction)
            {
                case Direction.North:
                    return _North;
                case Direction.East:
                    return _East;
                case Direction.South:
                    return _South;
                case Direction.West:
                    return _West;
                default:
                    return (Track)null;
            }
        }
    }
}