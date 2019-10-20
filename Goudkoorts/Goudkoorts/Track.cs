using System;
using System.Collections.Generic;
using System.Text;

namespace Goudkoorts
{
    public abstract class Track
    {
        public Track _North { get; set; }
        public Track _South { get; set; }
        public Track _East { get; set; }
        public Track _West { get; set; }
        public Direction _OutDirection { get; set; }
        public Direction _InDirection { get; set; }
        protected abstract MoveableObject _Object { get; set; }
        public abstract void Remove();
        public abstract bool Add(MoveableObject Object);
        public abstract bool IsEmpty();
        public abstract Char ToChar();
        protected ConsoleColor BackgroundColor { get; set; }
        protected ConsoleColor ForegroundColor { get; set; }

        
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