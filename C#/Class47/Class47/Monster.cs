using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class47
{
    internal class Monster : Creature, Iattackable
    {
        public override string Say()
        {
            return "歐拉~歐拉~ (有 " + hp + " 滴血)";
        }
        public override string getName()
        {
            return "怪物";
        }
        public void attack(Creature target)
        {
            target.Injured(5);
        }
    }
}
