using System;
using System.Collections.Generic;
using System.Text;

namespace Goudkoorts
{
    public class Ship : MoveableObject
    {
        public override ConsoleColor SetColor()
        {
            throw new NotImplementedException();
        }

        protected override bool Move(Direction direction)
        {
            throw new NotImplementedException();
        }

        protected override char ToChar()
        {
            throw new NotImplementedException();
        }
    }
}