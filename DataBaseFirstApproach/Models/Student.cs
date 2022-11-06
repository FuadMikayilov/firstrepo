using System;
using System.Collections.Generic;

namespace DataBaseFirstApproach.Models
{
    public partial class Student
    {
        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
        public string? EmailAdress { get; set; }
    }
}
