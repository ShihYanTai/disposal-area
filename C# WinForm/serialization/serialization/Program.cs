using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;
using System.Xml.Linq;

namespace serialization
{
    [DataContract]
    class Person
    {
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember(Name = "Weight")]
        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var me = new Person()
            {
                FirstName = "Jamie",
                LastName = "King",
                Age = 25
            };
            var serializar = new DataContractSerializer(typeof(Person));
            var stream = new MemoryStream();
            serializar.WriteObject(stream, me);
            stream.Seek(0, SeekOrigin.Begin);
            Console.WriteLine(XElement.Parse(Encoding.ASCII.GetString(stream.GetBuffer()).Replace("\0","")));
            Console.ReadLine();
        }
    }
}
