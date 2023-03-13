using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck
{
    public class Animal
    {
        public string Name { get; set; }
    }

    public class Dog : Animal 
    {
        public string Breed { get; set; }
        public string FurColor { get; set;}
        public int Age { get; set; }

    }
}
