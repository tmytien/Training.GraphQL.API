using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Training.GraphQL.API.Model
{
    public class User
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long RoleId { get; set; }
        public virtual Role Role { get; set; }
        public long DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public IList<UserAsset> UserAssets { get; set; }
    }
}
