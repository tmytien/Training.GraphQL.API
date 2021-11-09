using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Training.GraphQL.API.Model
{
    public class Department
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }

        public static List<Department> GetDepartment()
        {
            var deps = new List<Department>();
            deps.Add(new Department { Id = 1, Name = "Admin" });
            deps.Add(new Department { Id = 2, Name = "HR" });
            return deps;
        }
    }
}
