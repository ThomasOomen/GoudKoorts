﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Goudkoorts
{
    public class Dock : SimpleTrack
    {
        public Dock(Direction inDirection, Direction outDirection, ConsoleColor color) : base(inDirection, outDirection)
        {
            this._InDirection = inDirection;
            this._OutDirection = outDirection;
            this.ForegroundColor = color;
            this.BackgroundColor = ConsoleColor.Black;
        }
        protected override Cart _Cart { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override bool Add(Cart cart)
        {
            throw new NotImplementedException();
        }

        public override void Remove()
        {
            throw new NotImplementedException();
        }
    }
}