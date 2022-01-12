using System;
using System.ComponentModel.DataAnnotations;
namespace WebApp.Models
{
    public class TblEmployee
    {
        [Key]
        public Guid EmpName { get; set; }
        public string EmpSurname { get; set; }
        public string EmpAddress { get; set; }
        public int EmpPhone { get; set; }
    }
}