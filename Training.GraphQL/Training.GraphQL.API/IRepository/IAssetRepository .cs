using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Training.GraphQL.API.Model;

namespace Training.GraphQL.API.IRepository
{
    public interface IAssetRepository
    {
        List<Asset> GetAll();
        Asset GetById(long id);
    }
}