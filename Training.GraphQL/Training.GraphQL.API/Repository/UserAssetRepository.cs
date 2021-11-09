using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Training.GraphQL.API.IRepository;
using Training.GraphQL.API.Model;

namespace Training.GraphQL.API.Repository
{
    public class UserAssetRepository : IUserAssetRepository
    {
        private readonly List<UserAsset> userAssets = new List<UserAsset>()
        {
            new UserAsset { Id = 1, UserId = 1, AssetId = 1},
            new UserAsset { Id = 2, UserId = 1, AssetId = 2},

        };
        public IEnumerable<UserAsset> GetAll()
        {
            return userAssets.ToList();
        }

        public UserAsset GetById(long id)
        {
            return userAssets.SingleOrDefault(x => x.Id.Equals(id));
        }

        public IEnumerable<UserAsset> GetByAssetId(long id)
        {
            return userAssets.Where(x => x.AssetId.Equals(id)).ToList();
        }

        public IList<UserAsset> GetByUserId(long id)
        {
            return userAssets.Where(x => x.UserId.Equals(id)).ToList();
        }

        public UserAsset CreateUserAsset(UserAsset userAsset)
        {
            userAssets.Add(userAsset);
            return userAsset;
        }

        public UserAsset UpdateUserAsset(UserAsset dbUserAsset, UserAsset userAsset)
        {
            dbUserAsset.UserId = userAsset.UserId;
            dbUserAsset.AssetId = userAsset.AssetId;
            return dbUserAsset;
        }

    }
}