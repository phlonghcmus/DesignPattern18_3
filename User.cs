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
        public User(string email, string name,string phone)
        {
            this.email = email;
            this.name = name;
            this.Phone = phone;
        }
        [Required(ErrorMessage = "Email là bắt buộc")]
        [Email(ErrorMessage = "Phải đúng định dạng email (có chứa @)")]
        public string email { get ; set; }
        [Range(LengthMin = 8, LengthMax = 50, ErrorMessage = "Phải dài từ 8-50 ký tự")]
        public string name { get; set; }

        [Required(ErrorMessage ="Phone là bắt buộc")]
        [Phone(ErrorMessage ="Số điện thoại không hợp lệ")]
        public string Phone { get; set; }
    }
}
