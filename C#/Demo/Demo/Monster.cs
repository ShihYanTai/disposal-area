using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Monster : Creature
    {
        public void Attack(Creature c)
        {
            c.Injured(10);
        }

        public Monster(String name)
        {
            this.name = name;
        }

        public override string move()
        {
            return name + " 橫著走";
        }

    }
}
