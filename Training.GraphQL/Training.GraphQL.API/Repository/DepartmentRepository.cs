using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Training.GraphQL.API.IRepository;
using Training.GraphQL.API.Model;

namespace Training.GraphQL.API.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly List<Department> depts = new List<Department>()
        { 
            new Department {Id= 1, Name = "depts 1"},
            new Department {Id= 2, Name= "depts 2"}
        };

        public List<Department> GetAll()
        {
            return depts.ToList();
        }

        public Department GetById(long id)
        {
            return depts.SingleOrDefault(x => x.Id.Equals(id));
        }
    }
}