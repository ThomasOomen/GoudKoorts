using System;
using System.Collections.Generic;
using System.Text;

namespace Goudkoorts
{
    class Shipyard : Track
    {
        public override Cart _Cart { get; set; }
        public Ship _Ship { get; set; }

        public Shipyard()
        {
            _Ship = new Ship();
        }

        public override bool Add(Cart cart)
        {
            return false;
        }

        public override bool IsEmpty()
        {
            if (_Ship == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool MoveCart()
        {
            return false;
        }
        
        public void NewShip()
        {
            if (IsEmpty())
            {
                Random r = new Random();
                if (r.Next(0, 2) != 0)
                {
                    this._Ship = new Ship();
                }
            }
        }

        public override void Remove()
        {
            if (_Ship.IsFull())
            {
                Random r = new Random();
                if (r.Next(0, 2) != 0)
                {
                    _Ship = null;
                }
            }
        }

        public override char ToChar()
        {
            if (IsEmpty())
            {
                return 'S';
            }
            else
            {
                return _Ship.ToChar();
            }
        }
    }
}
