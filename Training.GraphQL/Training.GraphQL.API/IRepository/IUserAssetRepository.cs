using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Training.GraphQL.API.Model;

namespace Training.GraphQL.API.IRepository
{
    public interface IUserAssetRepository
    {
        IEnumerable<UserAsset> GetAll();
        UserAsset GetById(long id);
        IEnumerable<UserAsset> GetByAssetId(long id);
        IList<UserAsset> GetByUserId(long id);
        UserAsset CreateUserAsset(UserAsset userAsset);
        UserAsset UpdateUserAsset(UserAsset dbUserAsset, UserAsset userAsset);
    }
}
