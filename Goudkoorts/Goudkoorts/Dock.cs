﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Goudkoorts
{
    public class Dock : Track
    {
        public Dock(Direction inDirection, Direction outDirection)
        {
            this._InDirection = inDirection;
            this._OutDirection = outDirection;
        }
        protected override MoveableObject _Object { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        protected override bool Add(MoveableObject Object)
        {
            throw new NotImplementedException();
        }

        protected override string ObjectToString()
        {
            throw new NotImplementedException();
        }

        protected override void Remove()
        {
            throw new NotImplementedException();
        }
    }
}