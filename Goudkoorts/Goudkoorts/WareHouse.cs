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

        protected override Cart _Cart { get; set; }

        public override bool Add(Cart cart)
        {
            if(IsEmpty())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool IsEmpty()
        {
            if(this._Cart == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Remove()
        {
            this._Cart = null;
        }

        public override char ToChar()
        {
            return _DisplayChar;
        }
    }
}