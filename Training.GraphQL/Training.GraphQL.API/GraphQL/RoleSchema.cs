using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Training.GraphQL.API.GrahQL
{
    public class RoleSchema: Schema
    {
        public RoleSchema(IServiceProvider sp) : base(sp)
        {
            Query = sp.GetRequiredService<RoleQuery>();
            Mutation = sp.GetRequiredService<RoleMutation>();
        }
    }
}
