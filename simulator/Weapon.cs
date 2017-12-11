using System;

namespace simulator
{
    internal class Weapon
    {
        private Die _damageDie;
        private int _numberOfDice;
        /*
         * To add: Crit range, Crit modifier
         * Should magic go here or in its own class?
         */

        public Weapon(Die damageDie, int numberOfDice)
        {
            _damageDie = damageDie;
            _numberOfDice = numberOfDice;
        }

        private int Roll()
        {
            return _damageDie.Roll(_numberOfDice);
        }
    }
}