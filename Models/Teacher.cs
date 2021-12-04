using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NetCoreDemo.Models
{
    [Table("Teacher")]
    public class Teacher : Person
    {
        public string Universisty { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}