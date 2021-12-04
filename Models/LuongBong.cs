using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NetCoreDemo.Models
{
    [Table("LuongBong")]
    public class LuongBong
    {
        [Key]
        public int Id { get; set; }
        public int NhanVienId { get; set; }

        public NhanVien NhanViens { get; set; }
    }
}