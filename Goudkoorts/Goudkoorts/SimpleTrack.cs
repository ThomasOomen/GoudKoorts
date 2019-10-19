﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Goudkoorts
{
    public class SimpleTrack : Track
    {
        public SimpleTrack(Direction inDirection, Direction outDirection)
        {
            this._InDirection = inDirection;
            this._OutDirection = outDirection;
        }

        protected override MoveableObject _Object { get; set; }

        public SimpleTrack(Direction inDirection, Direction outDirection)
        {
            this._InDirection = inDirection;
            this._OutDirection = outDirection;
        }

        protected override bool Add(MoveableObject Object)
        {
            if (IsEmpty())
            {
                this._Object = Object;
                return true;
            }
            else
            {
                return false;
            }
        }

        protected override bool IsEmpty()
        {
            if (this._Object == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected override char ToChar()
        {
            if ((this._InDirection == Direction.North && this._OutDirection == Direction.South) || (this._InDirection == Direction.South && this._OutDirection == Direction.North))
            {
                return (char)186;
            }
            else if ((this._InDirection == Direction.West && this._OutDirection == Direction.East) || (this._InDirection == Direction.East && this._OutDirection == Direction.West))
            {
                return (char)205;
            }
            else if ((this._InDirection == Direction.West && this._OutDirection == Direction.North) || (this._InDirection == Direction.North && this._OutDirection == Direction.West))
            {
                return (char)188;
            }
            else if ((this._InDirection == Direction.West && this._OutDirection == Direction.South) || (this._InDirection == Direction.South && this._OutDirection == Direction.West))
            {
                return (char)187;
            }
            else if ((this._InDirection == Direction.East && this._OutDirection == Direction.North) || (this._InDirection == Direction.North && this._OutDirection == Direction.East))
            {
                return (char)200;
            }
            else if ((this._InDirection == Direction.East && this._OutDirection == Direction.South) || (this._InDirection == Direction.South && this._OutDirection == Direction.East))
            {
                return (char)201;
            }
            else
            {
                return '\0';
            }
        }


        protected override void Remove()
        {
            this._Object = null;
        }
    }
}