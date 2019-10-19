using System;
using System.Collections.Generic;
using System.Text;

namespace Goudkoorts
{
    public class MarshallYard : Track
    {
        public MarshallYard(String inputDirectionCar, String outputDirectionCar)
        {

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