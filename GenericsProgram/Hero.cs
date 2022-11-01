using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProgram
{
    internal abstract class Hero
    {
        int Id { get; set; }
        public string? Name { get; set; }

        public Hero(int id, string name)
        {
            Id = id;
            Name = name;           
        }
    }
}
