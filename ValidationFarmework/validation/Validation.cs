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
        public Validation()
        {
        }

        public HashSet<IViolation> validate(Object o)
        {
            HashSet<IViolation> violations = new HashSet<IViolation>();
            foreach (var item in o.GetType().GetProperties())
            {
                object[] annotations = item.GetCustomAttributes(false);
                foreach (Attribute attr in annotations)
                {
                    ValidatorFactory validatorFactory = new ValidatorFactory();
                    Validator validator = validatorFactory.create(attr.GetType().Name);
                    IViolation violation = validator.validate(item, o);
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
