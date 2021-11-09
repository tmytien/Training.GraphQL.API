using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Training.GraphQL.API.IRepository;
using Training.GraphQL.API.Model;

namespace Training.GraphQL.API.Repository
{
    public class RoleRepository : IRoleRepository
    {
        private readonly List<Role> roles = new List<Role>()
        {
            new Role {Id = 1, Name = "Admin"},
            new Role {Id= 2, Name="User"}
        };

        public List<Role> GetAll()
        {
            return roles;
        }

        public Role GetById(long id)
        {
            return roles.SingleOrDefault(x=>x.Id == id);
        }

        public List<Role> AddRole(Role role)
        {
            role.Id = roles.Max(x => x.Id) + 1;
            roles.Add(role);
            return roles;
        }

        public Role UpdateRole(Role roledb, Role role)
        {
            roledb.Name = role.Name;
            return roles.Where(x => x.Id == roledb.Id).Select(x => roledb).SingleOrDefault();
        }

        public void DeleteRole(long id)
        {
            var role = roles.FindIndex(x => x.Id == id);
            roles.RemoveAt(role);
        }
    }
}