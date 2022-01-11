using Project.ValidationFarmework.violation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Project.ValidationFarmework.validator
{
    public abstract class Validator
    {
       public Violation validate(PropertyInfo prop, object o)
       {
            Object value = prop.GetValue(o);
            Violation violation = new ImplViolation(prop.Name,value);
            if (this.invalid(prop, value))
            {
                violation.setMessage(this.getMessage(prop));
                violation.setValid(false);
            }
            return violation;
       }

        protected abstract bool invalid(PropertyInfo prop, object value);
        protected abstract string getMessage(PropertyInfo prop);
 /*       private string getMessage(PropertyInfo prop)
        {
            T attr = (T)Attribute.GetCustomAttribute(prop, typeof(T));
            return attr.ErrorMessage;
        }*/
    }
}
