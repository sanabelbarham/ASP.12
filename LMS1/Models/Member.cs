using LMS1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LMS1.Models
{
    class Member : AbstractPerson
    {
        public Member(int id, string name) : base(id, name)
        {
            Id = id;
            Name = name;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"name is {Name} and id is{Id}");
        }

     
    }
}
