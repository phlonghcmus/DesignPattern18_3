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
        public User(string taikhoan, string matkhau,string email)
        {
            this.email = taikhoan;
            this.name = matkhau;
            this.Phone = email;
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
