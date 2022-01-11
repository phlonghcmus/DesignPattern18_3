using Project.ValidationFarmework.validator;
using Project.ValidationFarmework.violation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ValidationFarmework.validation
{
    public class Validation
    {
        private static Validation _instance;
        public Validation()
        {
        }
        public static Validation GetInstance()
        {
            if(_instance == null)
            {
                _instance = new Validation();
            }
            return _instance;
        }

        public HashSet<Violation> validate(Object o)
        {
            HashSet<Violation> violations = new HashSet<Violation>();
            foreach (var item in o.GetType().GetProperties())
            {
                object[] annotations = item.GetCustomAttributes(false);
                foreach (Attribute attr in annotations)
                {
                    ValidatorFactory validatorFactory = new ValidatorFactory();
                    Validator validator = validatorFactory.create(attr.GetType().Name);
                    Violation violation = validator.validate(item, o);
                    if (violation.getValid() == false)
                    {
                        violations.Add(violation);
                    }
                }
            }
            return violations;
        }
    }
}
