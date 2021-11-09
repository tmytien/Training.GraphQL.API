using System;
using System.Collections.Generic;
using System.Linq;
using Training.GraphQL.API.IRepository;
using Training.GraphQL.API.Model;

namespace Training.GraphQL.API.Repository
{
    public class AssetRepository : IAssetRepository
    {
        private readonly List<Asset> assets = new List<Asset>()
        {
            new Asset { Id=1, Name="Keyboard", Source="Amazon", 
                        UserAssets = new List<UserAsset>() { new UserAsset { Id = 1 , UserId = 1, AssetId = 1} } },
            new Asset { Id=1, Name="Screen", Source="Google", 
                        UserAssets =new List<UserAsset>() { new UserAsset { Id = 1 , UserId = 1, AssetId = 2} } }
        };
        public List<Asset> GetAll()
        {
            return assets.ToList();
        }

        public Asset GetById(long id)
        {
            return assets.SingleOrDefault(x => x.Id.Equals(id));
        }
    }
}