using System;
using System.Collections.Generic;
using System.Text;

namespace Goudkoorts
{
    public class Ship
    {
        int Counter;

        public Ship()
        {
            Counter = 0;
        }
        public ConsoleColor SetColor()
        {
            throw new NotImplementedException();
        }

        public bool AddLoad()
        {
            if(IsFull())
            {
                return false;
            }
            else
            {
                Counter++;
                return true;
            }

        }

        public bool IsFull()
        {
            if(Counter == 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public char ToChar()
        {
            String number = Counter.ToString();
            char display = char.Parse(number);
            if(IsFull())
            {
                return 'X';
            }
            else
            {
                return display;
            }
        }
    }
}
