using Project.ValidationFarmework.validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ValidationFarmework.validation
{
    public class Validation
    {
        public Validation()
        {
        }

        public void validate(Object o)
        {
            foreach (var item in o.GetType().GetProperties())
            {
                Console.WriteLine(item.Name);
                object[] annotations = item.GetCustomAttributes(false);
                foreach (Attribute attr in annotations)
                {
                    /*Validator validator = ValidatorFactory.create(attr.GetType().Name);*/
                    Console.WriteLine(attr.GetType().Name);
                }
            }    
        }
    }
}
