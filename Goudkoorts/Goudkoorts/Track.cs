using System;
using System.Collections.Generic;
using System.Text;

namespace Goudkoorts
{
    public class Track
    {
        protected Track _North;
        protected Track _South;
        protected Track _East;
        protected Track _West;
        protected Direction _Direction;
        
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