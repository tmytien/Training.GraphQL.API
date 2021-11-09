using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Training.GraphQL.API.Model;

namespace Training.GraphQL.API.GrahQL.Type
{
    public class RoleInputType : InputObjectGraphType<Role>
    {
        public RoleInputType()
        {
            Name = "roleInput";
            Field<NonNullGraphType<StringGraphType>>("Name");
        }
    }
}
