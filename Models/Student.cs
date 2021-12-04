using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NetCoreDemo.Models
{
    [Table("Students")]
    public class Student
    {
        [Key]
        [Display(Name = "Mã Sinh Viên")]
        public string StudentID { get; set; }
        [Display(Name = "Tên Sinh Viên")]
        public string StudentName {get; set;}
        [Display(Name = "Địa chỉ")]
        public string Address {get; set;}
        [Display(Name = "Số điện thoại")]
        public string SoDienThoai {get; set;}
    }
}