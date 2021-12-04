using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NetCoreDemo.Models;
namespace NetCoreDemo.Data{
    public class NetCoreDbContext : DbContext
    {
        public NetCoreDbContext (DbContextOptions<NetCoreDbContext> options)
            : base(options)
        {
        }

        public DbSet<NetCoreDemo.Models.Movie> Movie { get; set; }

        public DbSet<NetCoreDemo.Models.Employee> Employee { get; set; }

        public DbSet<NetCoreDemo.Models.Person> Person { get; set; }

        public DbSet<NetCoreDemo.Models.Product> Product { get; set; }

        public DbSet<NetCoreDemo.Models.Student> Student { get; set; }

        public DbSet<NetCoreDemo.Models.Teacher> Teacher { get; set; }

        public DbSet<NetCoreDemo.Models.KhachHang> KhachHang { get; set; }

        public DbSet<NetCoreDemo.Models.HoaDon> HoaDon { get; set; }

        public DbSet<NetCoreDemo.Models.NhanVien> NhanVien { get; set; }

        public DbSet<NetCoreDemo.Models.LuongBong> LuongBong { get; set; }

        public DbSet<NetCoreDemo.Models.SinhVien> SinhVien { get; set; }
    }

}