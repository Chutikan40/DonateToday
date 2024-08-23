using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DonateToday.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("อีเมลผู้ใช้")]
        public string Email { get; set; }
        [Required]
        [DisplayName("รหัสผ่าน")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "รหัสผ่านต้องมีความยาวระหว่าง 8 ถึง 100 ตัวอักษร")]
        public string Password { get; set; }
    }
}
