using Project.ValidationFarmework.anotation;
using System;
using System.Reflection;

namespace Project.ValidationFarmework.validator
{
    internal class RequiredValidator : Validator
    {
        public RequiredValidator()
        {

        }

        protected override string getMessage(PropertyInfo prop)
        {
            Required attr = (Required)Attribute.GetCustomAttribute(prop, typeof(Required));
            return attr.ErrorMessage;
        }

        protected override bool invalid(PropertyInfo prop, object value)
        {
            if (value is string)
            {
                return (string.IsNullOrEmpty(((string)value)));
            }
            return false;
        }
    }
}