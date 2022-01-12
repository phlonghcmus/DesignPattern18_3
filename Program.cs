using Project.ValidationFarmework.validation;
using Project.ValidationFarmework.violation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            User user = new User("", "Phạm Hoàng Long", "113");
            Validation validation = new Validation();
            HashSet<Violation> violations = validation.validate(user);
            foreach (Violation violation in violations)
            {
                Console.WriteLine(violation.getProp() + "-->" + violation.getMessage());
            }
        }
    }
}
