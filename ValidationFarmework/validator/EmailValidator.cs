using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Project.ValidationFarmework.anotation;
using Project.ValidationFarmework.helper;


namespace Project.ValidationFarmework.validator
{
    internal class EmailValidator : Validator
    {
        public EmailValidator()
        {

        }
        protected override string getMessage(PropertyInfo prop)
        {
            Email attr=(Email)Attribute.GetCustomAttribute(prop, typeof(Email));
            return attr.ErrorMessage;
        }

        protected override bool invalid(PropertyInfo prop, object value)
        {
            return !ValidationHelper.IsValidEmail((string)value); 
        }
    }
}
