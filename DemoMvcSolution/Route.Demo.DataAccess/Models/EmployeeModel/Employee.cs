﻿
using System.ComponentModel.DataAnnotations.Schema;
using Route.Demo.DataAccess.Models.DepartmentModel;
using Route.Demo.DataAccess.Models.Shared.Classes;
using Route.Demo.DataAccess.Models.Shared.Enums;

namespace Route.Demo.DataAccess.Models.EmployeeModel
{
   public class Employee : BaseEntity
    {
        public string Name { get; set; } = null!;
        public int Age { get; set; }
        public string? Address { get; set; }
        public decimal Salary { get; set; }
        public bool IsActive { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime HireDate { get; set; }
        public Gender Gender { get; set; }
        public EmployeeType EmployeeType { get; set; }
        [ForeignKey("DepartmentId")]
        public int? DepartmentId { get; set; }
        public virtual Department? Department { get; set; }
    }
}
