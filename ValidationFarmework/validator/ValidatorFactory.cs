using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ValidationFarmework.validator
{
    public class ValidatorFactory
    {
        private static ValidatorFactory instance = new ValidatorFactory();
        public static ValidatorFactory getInstance()
        {
            return instance;
        }
        private static Dictionary<string, Validator> validatorMap = new Dictionary<string,Validator>();

        private void Init()
        {
            validatorMap.Clear();
            validatorMap.Add("Required", new RequiredValidator());
            validatorMap.Add("Min", new MinValidator());
        }
        public ValidatorFactory()
        {
            Init();
        }

        private static bool CheckValidatorType(string strTypeValidator)
        {

            return validatorMap.ContainsKey(strTypeValidator);
        }

        public static Validator create(string strTypeValidator)
        {
            Console.WriteLine(strTypeValidator);
            if (CheckValidatorType(strTypeValidator))
                return validatorMap[strTypeValidator];
            return null;
        }
    }
}
