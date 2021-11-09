using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Training.GraphQL.API.Model;

namespace Training.GraphQL.API.IRepository
{
    public interface IRoleRepository
    {
        List<Role> GetAll();
        Role GetById(long id);
        List<Role> AddRole(Role role);
        Role UpdateRole(Role roledb, Role role);
        void DeleteRole(long id);
    }
}