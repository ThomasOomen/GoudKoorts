using System;
using System.Collections.Generic;
using System.Text;

namespace Goudkoorts
{
    public abstract class MoveableObject
    {
        protected Track _Track;
        protected abstract bool Move(Direction direction);
        protected abstract Char ToChar();
        protected abstract bool HasLoad();
    }
}