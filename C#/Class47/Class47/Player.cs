using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class47
{
    internal class Player : Creature, Iattackable, ITalkable
    {
        public override string getName()
        {
            return "玩家";
        }
        public void attack(Creature target)
        {
            target.Injured(30);
        }
        public string talkTo(Creature target)
        {
            return "Hi~ " + target.getName() + "! 我是玩家!";
        }
    }
}
