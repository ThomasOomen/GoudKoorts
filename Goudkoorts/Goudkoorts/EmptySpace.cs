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

        public override bool Add(MoveableObject Object)
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
