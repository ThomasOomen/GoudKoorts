using System;
using System.Collections.Generic;
using System.Text;

namespace Goudkoorts
{
    public class WareHouse : Track
    {
        private String _letter;
        public WareHouse(string value)
        {
            this._letter = value;
        }

        public String getLetter()
        {
            return _letter;
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

        public override char ToChar()
        {
            return char.Parse(_letter);
        }
    }
}