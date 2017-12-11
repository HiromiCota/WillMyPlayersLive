using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulator
{
    class Monster
    {
        Entity Body;
        Weapon Equipped;

        public Monster()
        {
            Body = new Entity(new Die(8), 1);
            Equipped = new Weapon(new Die(8), 1);
        }

        int GetHp()
        {
            return Body.GetHp();
        }
    }
}
