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
        protected Direction _Direction { get; set; }
        protected abstract MoveableObject _Object { get; set; }
        protected abstract void Remove();
        protected abstract bool Add(MoveableObject Object);
        protected abstract String ObjectToString();

        public Track(Track north, Track south, Track east, Track west, Direction direction)
        {
            _North = north;
            _South = south;
            _East = east;
            _West = west;
            _Direction = direction;
        }
        
        public Track TrackInDirection()
        {
            switch(_Direction)
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