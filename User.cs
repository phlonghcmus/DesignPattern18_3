using Project.ValidationFarmework.anotation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class User
    {
        public User(string email, string name)
        {
            this.email = email;
            this.name = name;
        }
        [Min(Length = 8, ErrorMessage = "Phải dài tối thiểu 8 ký tự")]
        [Required(ErrorMessage = "Email là bắt buộc")]
        [Max(Length=50,ErrorMessage = " Email dài tối đa là 50")]
        public string email { get ; set; }
        [Min(Length = 8,ErrorMessage = "Phải dài tối thiểu 8 ký tự")]
        public string name { get; set; }
    }
}
