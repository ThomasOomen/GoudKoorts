using System;
using System.Collections.Generic;
using System.Text;

namespace Goudkoorts
{
    public class WareHouse : Track
    {
        private String _letter;
        public WareHouse()
        {

        }
        public String Letter
        {
            get
            {
                return _letter;
            }

            set
            {
                Letter = value;
            }
        }

        protected override MoveableObject _Object { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        protected override bool Add(MoveableObject Object)
        {
            throw new NotImplementedException();
        }

        protected override bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        protected override void Remove()
        {
            throw new NotImplementedException();
        }

        protected override char ToChar()
        {
            throw new NotImplementedException();
        }
    }
}