using Project.ValidationFarmework.anotation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Range = Project.ValidationFarmework.anotation.Range;

namespace Project
{
    public class User
    {
        public User(string email, string name)
        {
            this.email = email;
            this.name = name;
        }
        [Required(ErrorMessage = "Email là bắt buộc")]
/*        [Range(LengthMax=8,LengthMin=50,ErrorMessage= "Email dài trong khoảng 8 đến 50")]*/
        public string email { get ; set; }
        [Min(Length = 8,ErrorMessage = "Phải dài tối thiểu 8 ký tự")]
        public string name { get; set; }
    }
}
