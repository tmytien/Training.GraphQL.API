using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Training.GraphQL.API.IRepository;
using Training.GraphQL.API.Model;

namespace Training.GraphQL.API.GrahQL
{
    public class RoleQuery : ObjectGraphType<object>
    {
        public RoleQuery(IRoleRepository repository)
        {
            Field<ListGraphType<RoleType>>("roles",
                resolve: context => repository.GetAll());
            Field<RoleType>("role",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<LongGraphType>> { Name = "roleId" }),
                resolve: context =>
                {
                    var roleId = context.GetArgument<long>("roleId");
                    return repository.GetById(roleId); ;
                });
        }
    }
}
