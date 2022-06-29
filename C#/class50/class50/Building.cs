using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class50
{
    internal class Building<P>
    {
        List<P> people = new List<P>();
        public void Add(P person)
        {
            people.Add(person);
        }

        public override string ToString()
        {
            String output = "這棟大樓有 : \r\n";

            for (int i = 0; i < people.Count; i++)
            {
                output += people[i].ToString() + "\r\n";
            }
            return output;
        }
    }
}
