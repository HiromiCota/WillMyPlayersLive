using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulator
{
    class Die
    {
        private int _minValue;
        private int _maxValue;
        private Random _roller;

        public Die(int dieFaces)
        {
            _minValue = 1;
            _maxValue = dieFaces;
            _roller = new Random();
        }

        public Die(int low, int high)
        {
            _minValue = low;
            _maxValue = high;
            _roller = new Random();
        }

        public int Roll()
        {
            return _roller.Next(_minValue, _maxValue);
        }

        public int Roll(int number)
        {
            int output = 0;
            for (int i = 0; i < number; i++)
                output += this.Roll();
            return output;
        }
    }
}
