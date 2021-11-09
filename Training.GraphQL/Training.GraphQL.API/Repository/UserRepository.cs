using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Training.GraphQL.API.IRepository;
using Training.GraphQL.API.Model;

namespace Training.GraphQL.API.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly List<User> users = new List<User>()
        {
            new User { Id = 1, Name = "a", RoleId = 1, DepartmentId = 1,
                        UserAssets = new List<UserAsset>() { new UserAsset { Id = 1 , UserId = 1, AssetId = 1}, new UserAsset { Id = 1, UserId = 1, AssetId = 2 } } },
            new User { Id = 2, Name = "b", RoleId = 2, DepartmentId = 1},
        };
        public IEnumerable<User> GetAll()
        {
            return users.ToList();
        }

        public User GetById(long id)
        {
            return users.SingleOrDefault(x => x.Id.Equals(id));
        }
    }
}