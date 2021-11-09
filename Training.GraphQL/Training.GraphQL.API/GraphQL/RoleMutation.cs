using GraphQL;
using GraphQL.Types;
using Training.GraphQL.API.GrahQL.Type;
using Training.GraphQL.API.IRepository;
using Training.GraphQL.API.Model;

public class RoleMutation : ObjectGraphType<object>
{
    public RoleMutation(IRoleRepository repository)
    {
        Field<ListGraphType<RoleType>>(
                "createRole",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<RoleInputType>> { Name = "role" }),
                resolve: context =>
                {
                    var role = context.GetArgument<Role>("role");
                    return repository.AddRole(role);
                });
        Field<StringGraphType>(
            "deleteRole",
             arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "roleId" }),
             resolve: context =>
             {
                 var roleId = context.GetArgument<long>("roleId");
                 repository.DeleteRole(roleId);
                 return $"The user has been deleted";
             });
        Field<RoleType>(
            "updateRole",
             arguments: new QueryArguments(new QueryArgument<NonNullGraphType<RoleInputType>> { Name = "role" },
                                           new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "roleId" }),
             resolve: context =>
             {
                 var role = context.GetArgument<Role>("role");
                 var roleId = context.GetArgument<long>("roleId");
                 var roleDb = repository.GetById(roleId);
                 if (roleDb is null)
                 {
                     context.Errors.Add(new ExecutionError("Couldn't find"));
                     return null;
                 }
                 return repository.UpdateRole(roleDb, role);
             });
    }
}