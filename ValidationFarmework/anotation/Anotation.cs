using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ValidationFarmework.anotation
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Method)]
    public abstract class Anotation : Attribute
    {
        public string ErrorMessage { get; set; }

        
    }
}
