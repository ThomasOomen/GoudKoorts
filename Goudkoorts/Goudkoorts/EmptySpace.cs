using System;
using System.Collections.Generic;
using System.Text;

namespace Goudkoorts
{
    class EmptySpace : Track
    {
        protected override MoveableObject _Object
        { get
            {
                return (MoveableObject)null;
            }
            set
            {
            }
        }

        protected override bool Add(MoveableObject Object)
        {
            return false;
        }

        protected override bool IsEmpty()
        {
            return false;
        }

        protected override void Remove()
        {
        }

        protected override char ToChar()
        {
            return ' ';
        }
    }
}
