using System;
using System.Collections.Generic;
using System.Text;

namespace Goudkoorts
{
    public class SimpleTrack : Track
    {
        public SimpleTrack(String inputDirectionCar, String outputDirectionCar)
        {

        }

        protected override MoveableObject _Object { get; set; }

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