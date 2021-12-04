using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NetCoreDemo.Models
{
    [Table("KhachHang")]
    public class KhachHang
    {
        [Key]
        public int KhachHangId { get; set; }
        public string TenKhachHang { get; set; }
        public ICollection<HoaDon> hoadons { get; set; }
    }
}