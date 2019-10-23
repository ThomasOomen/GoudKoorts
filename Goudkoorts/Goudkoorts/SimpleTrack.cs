﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Goudkoorts
{
    public class SimpleTrack : Track
    {
        protected override Cart _Cart { get; set; }

        public SimpleTrack(Direction inDirection, Direction outDirection)
        {
            this._InDirection = inDirection;
            this._OutDirection = outDirection;
            this.ForegroundColor = ConsoleColor.White;
            this.BackgroundColor = ConsoleColor.Black;
        }

        public override bool Add(Cart cart)
        {
            if (IsEmpty())
            {
                this._Cart = cart;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool IsEmpty()
        {
            if (this._Cart == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override char ToChar()
        {
            if ((this._InDirection == Direction.North && this._OutDirection == Direction.South) || (this._InDirection == Direction.South && this._OutDirection == Direction.North))
            {
                return '║';
            }
            else if ((this._InDirection == Direction.West && this._OutDirection == Direction.East) || (this._InDirection == Direction.East && this._OutDirection == Direction.West))
            {
                return '═';
            }
            else if ((this._InDirection == Direction.West && this._OutDirection == Direction.North) || (this._InDirection == Direction.North && this._OutDirection == Direction.West))
            {
                return '╝';
            }
            else if ((this._InDirection == Direction.West && this._OutDirection == Direction.South) || (this._InDirection == Direction.South && this._OutDirection == Direction.West))
            {
                return '╗';
            }
            else if ((this._InDirection == Direction.East && this._OutDirection == Direction.North) || (this._InDirection == Direction.North && this._OutDirection == Direction.East))
            {
                return '╚';
            }
            else if ((this._InDirection == Direction.East && this._OutDirection == Direction.South) || (this._InDirection == Direction.South && this._OutDirection == Direction.East))
            {
                return '╔';
            }
            else
            {
                return '\0';
            }
        }


        public override void Remove()
        {
            this._Cart = null;
        }
    }
}