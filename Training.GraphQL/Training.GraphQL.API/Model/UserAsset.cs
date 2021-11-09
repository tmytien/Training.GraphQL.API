using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Training.GraphQL.API.Model
{
    public class UserAsset
    {
        [Key]
        public long Id { get; set; }
        public long AssetId { get; set; }
        public virtual Asset Asset { get; set; }
        public long UserId { get; set; }
        public virtual User User { get; set; }
    }
}
