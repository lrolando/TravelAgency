using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DataAccess.Repository
{
    public class GetFromDB
    {
        public async Task<IEnumerable<ClientType>> ClientTypes()
        {

            IEnumerable<ClientType> ty = null;

            using (AppDBContexts db = new AppDBContexts())
            {
                ty = await (from a in db.ClientTypes
                            select a).ToListAsync();
            }

            return ty;

        }

        public async Task<IEnumerable<Package>> Packageslist(string name)
        {

            IEnumerable<Package> PackList = null;

            using (AppDBContexts db = new AppDBContexts())
            {
                PackList = await (from a in db.Packages
                                  where a.Namepack.Contains(name)
                                  select a).ToListAsync();
            }

            return PackList;

        }

        public async Task<Package> DetailsPackage(Package pack)
        {

            using (AppDBContexts db = new AppDBContexts())
            {
                pack.Product = await (from a in db.Product
                                      where a.IDPack.Equals(pack.PackageID)
                                      select a).ToListAsync();
            }

            return pack;

        }

        public async Task<IEnumerable<Product>> Productlist(int[] packag)
        {

            IEnumerable<Product> List = null;

            using (AppDBContexts db = new AppDBContexts())
            {
                //db.Database.Log() = Console.Write;
                List = await (from a in db.Product
                              join b in db.Packages
                              on a.IDPack equals b.PackageID
                              where packag.Select(p => p).Contains(b.PackageID)
                              select a).ToListAsync();

            }

            return List;

        }
    }
}
