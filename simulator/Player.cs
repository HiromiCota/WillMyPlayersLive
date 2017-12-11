using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulator
{
    class Player
    {
        Entity Body;
        Weapon Equipped;

        public Player()
        {
            Body = new Entity(new Die(8), 1);
            Equipped = new Weapon(new Die(8),1 );
        }

        int GetHp()
        {
            return Body.GetHp();
        }

    }
}
