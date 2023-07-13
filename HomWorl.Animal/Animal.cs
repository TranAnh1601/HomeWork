using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomWorl.Animal
{

    internal abstract class Animal
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public abstract string Sound();

       
    }
}
