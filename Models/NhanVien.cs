using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NetCoreDemo.Models
{
    [Table("NhanVien")]
    public class NhanVien
    {
        [Key]
        public int NhanVienId { get; set; }
        public string TenNhanVien { get; set; }
        public ICollection<LuongBong> LuongBongs { get; set; }
    }
}