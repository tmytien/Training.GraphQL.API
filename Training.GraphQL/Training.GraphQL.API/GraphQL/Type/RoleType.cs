using GraphQL.Types;
using Training.GraphQL.API.Model;

public sealed class RoleType : ObjectGraphType<Role>
{
    public RoleType()
    {
        Field(x => x.Id, type: typeof(IdGraphType)).Description("Id of Role");
        Field(m => m.Name).Description("Name of role");
    }
}