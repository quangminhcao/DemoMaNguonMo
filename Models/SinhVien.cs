using System;
using System.Security.AccessControl;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NetCoreDemo.Models{
    [Table("SinhViens")]
    public class SinhVien{
        [Key]
        public string SinhVienID { get; set; }
        
        public string HoTen { get; set; }
    }
}