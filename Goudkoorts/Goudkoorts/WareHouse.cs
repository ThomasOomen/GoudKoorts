using System;
using System.Collections.Generic;
using System.Text;

namespace Goudkoorts
{
    public class WareHouse : Track
    {
        private Char _DisplayChar;
        public WareHouse(Char value)
        {
            _DisplayChar = value;
            this.ForegroundColor = ConsoleColor.White;
            this.BackgroundColor = ConsoleColor.Black;
        }

        protected override MoveableObject _Object { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override bool Add(MoveableObject Object)
        {
            throw new NotImplementedException();
        }

        public override bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public override void Remove()
        {
            throw new NotImplementedException();
        }

        public override char ToChar()
        {
            return _DisplayChar;
        }
    }
}