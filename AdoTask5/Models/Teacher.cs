using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoTask5.Models
{
    public class Teacher : BaseEntity
    {
        public DateTime EmploymentDate { get; set; }
        public decimal Premium { get; set; }
        public decimal Salary { get; set; }
        public string Surname { get; set; }
    }
}
