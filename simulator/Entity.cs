using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulator
{
    class Entity
    {
        //Required values
        protected int _numberOfHitDice;
        protected Die _hitDice;

        //Optional values
        private int _damageMod;
        private int _toHitMod;
        private int _hitPointMod;

        //Derived values
        protected int _hitPointMax;
        protected int _hitPointNow;

        public Entity(Die _hitDice, int hitPointMax)
        {
            this._hitDice = _hitDice;
            this._hitPointMax = hitPointMax;
            CalculateValues(this);
        }

        private void CalculateValues(Entity creature)
        {
            creature._damageMod = 0;
            creature._toHitMod = 0;
            creature._hitPointMod = 0;
            creature._hitPointMax = _hitDice.Roll();
            creature._hitPointNow = _hitPointMax;
        }

        private void Heal(int healAmount)
        {
            _hitPointNow += healAmount;
            if (_hitPointNow > _hitPointMax)
            {
                healAmount = _hitPointNow - _hitPointMax;
                _hitPointNow = _hitPointMax;
                System.Console.Out.Write("Overhealed by: " + healAmount);
            }
            System.Console.Out.WriteLine("Current HP: " + _hitPointNow);

        }

        private Boolean Damage(int damageAmount)
        {
            _hitPointNow -= damageAmount;
            if (_hitPointNow <= 0)
            {
                if (_hitPointNow <= -10)
                {
                    System.Console.Out.WriteLine("Dead!");
                    return false;
                }
                System.Console.Out.WriteLine("Incapacitated!");
            }
            return true;
        }

        public int GetHp()
        {
            return _hitPointNow;
        }
    }
    
}
