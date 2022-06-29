using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class47
{
    abstract class Creature
    {
        protected int hp = 100;

        public void Injured(int damage)
        {
            if(damage > hp)
            {
                this.hp = 0;
            }
            else
            {
                this.hp -= damage;
            }
        }
        public virtual string Say()
        {
            return "我是 " + getName() + "，我有 " + hp + " 滴血";
        }

        public abstract string getName();
    }
}
