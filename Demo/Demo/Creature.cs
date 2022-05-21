using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Creature
    {
        private int hp =100;

        public int GetHP()
        {
            return hp;
        }

        public void Injured(int injuredPoint)
        {
            hp -= injuredPoint;
        }

        public string name;

        public virtual string move()
        {
            return name + "向前走";
        }

        public virtual string attack(Creature target)
        {
            return name + " 攻擊了 " + target.name;
        }
    }
}
