using System;
using System.Collections.Generic;
using System.Text;

namespace Goudkoorts
{
    class EmptySpace : Track
    {
        protected override Cart _Cart
        { get
            {
                return (Cart)null;
            }
            set
            {
            }
        }

        public override bool Add(Cart cart)
        {
            return false;
        }

        public override bool IsEmpty()
        {
            return false;
        }

        public override void Remove()
        {
        }

        public override char ToChar()
        {
            return ' ';
        }
    }
}
