using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ValidationFarmework.anotation
{
    public class Range : Anotation
    {
        public int LengthMax { get; set; }
        public int LengthMin { get; set; }
    }
}
