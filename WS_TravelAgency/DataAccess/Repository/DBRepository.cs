using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DataAccess.Repository
{
    public class DBRepository : IDBRepository
    {

        private readonly AppDBContexts _appDBContexts;

        public DBRepository(AppDBContexts appDBContexts)
        {
            _appDBContexts = appDBContexts;

        }


        public async Task<IEnumerable<ClientType>> GetClientTypes()
        {

            IEnumerable<ClientType> ty = null;

                ty = await (from a in _appDBContexts.ClientTypes
                            select a).ToListAsync();
            
            return ty;

        }

        public async Task<IEnumerable<Package>> GetPackageslist(string name)
        {

            IEnumerable<Package> PackList = null;

                PackList = await (from a in _appDBContexts.Packages
                                  where a.Namepack.Contains(name)
                                  select a).ToListAsync();
            
            return PackList;

        }

        public async Task<Package> GetDetailsPackage(Package pack)
        {

                pack.Product = await (from a in _appDBContexts.Product
                                      where a.IDPack.Equals(pack.PackageID)
                                      select a).ToListAsync();
            
            return pack;

        }

        public async Task<IEnumerable<Product>> GetProductlist(int[] packag)
        {

            IEnumerable<Product> List = null;

                //db.Database.Log() = Console.Write;
                List = await (from a in _appDBContexts.Product
                              join b in _appDBContexts.Packages
                              on a.IDPack equals b.PackageID
                              where packag.Select(p => p).Contains(b.PackageID)
                              select a).ToListAsync();


            return List;

        }
    }
}
