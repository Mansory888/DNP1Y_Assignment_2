using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Job
    {
        [Key]
        public int id { get; set; }
        public string JobTitle { get; set; }
        
        public int Salary { get; set; }

        public override string ToString()
        {
            return JobTitle + ", Salary: " + Salary;
        }
    }
}