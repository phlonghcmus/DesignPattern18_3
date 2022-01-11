using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ValidationFarmework.validator
{
    public class ValidatorFactory
    {
        private static Dictionary<string, Validator> validatorMap = new Dictionary<string,Validator>();

        private void Init()
        {
            validatorMap.Clear();
            validatorMap.Add("Required", new RequiredValidator());
            validatorMap.Add("Min", new MinValidator());
            validatorMap.Add("Email", new EmailValidator());

            validatorMap.Add("Phone", new PhoneValidator());

            validatorMap.Add("Range", new RangeValidator());
        }
        public ValidatorFactory()
        {
            Init();
        }

        private bool CheckValidatorType(string strTypeValidator)
        {

            return validatorMap.ContainsKey(strTypeValidator);
        }

        public Validator create(string strTypeValidator)
        {
            if (CheckValidatorType(strTypeValidator))
                return validatorMap[strTypeValidator];
            return null;
        }
    }
}
