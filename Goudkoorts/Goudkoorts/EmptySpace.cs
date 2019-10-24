using System;
using System.Collections.Generic;
using System.Text;

namespace Goudkoorts
{
    class EmptySpace : Track
    {
        private Ship _Ship { get; set; }
        public override Cart _Cart
        { get
            {
                return (Cart)null;
            }
            set
            {
            }
        }

        public Ship GetShip
        {
            get
            {
                return _Ship;
            }
            set
            {
                _Ship = value;
            }
        }
        public override bool MoveCart()
        {
            return false;
        }

        public override bool Add(Cart cart)
        {
            return false;
        }

        public override bool IsEmpty()
        {
            if(_Ship != null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override void Remove()
        {
            this._Ship = null;
        }

        public override char ToChar()
        {
            if (IsEmpty())
            {
                return ' ';
            }
            else
            {
                return _Ship.ToChar();
            }
        }
    }
}
