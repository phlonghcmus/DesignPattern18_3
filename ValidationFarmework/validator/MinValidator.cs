using Project.ValidationFarmework.anotation;
using System;
using System.Reflection;

namespace Project.ValidationFarmework.validator
{
    internal class MinValidator : Validator
    {
        public MinValidator()
        {
            
        }

        protected override string getMessage(PropertyInfo prop)
        {
            Min attr = (Min)Attribute.GetCustomAttribute(prop, typeof(Min));
            return attr.ErrorMessage;
        }

        protected override bool invalid(PropertyInfo prop, object value)
        {
            Min attr = (Min)Attribute.GetCustomAttribute(prop,typeof(Min));
            return (((string)value).Length < attr.Length);
        }
    }
}