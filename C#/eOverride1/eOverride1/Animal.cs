using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eOverride1
{
    internal class Animal
    {
        protected string kind = "動物";
        public string Mammal { get; set; }

        public virtual string msg()
        {
            return $"{Mammal} 是 {kind}";
        }
    }
}
