using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Villager : Creature
    {
        public Villager(string name)
        {
            this.name = name;
        }

        public override string attack(Creature target)
        {
            return name + "不能攻擊";
        }
    }
}
