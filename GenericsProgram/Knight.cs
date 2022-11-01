using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProgram
{
    internal class Knight:Hero
    {
        double Height { get; set; }

        public Knight(int id, string name, double height):base(id,name)
        {
            Height = height;
        }
        public override string ToString()
        {
            return base.Name; 
        }

    }            
}
