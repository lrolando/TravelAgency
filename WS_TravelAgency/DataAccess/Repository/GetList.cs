using DataAccess.Models;
using DataAccess.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DataAccess.Repository
{
    public class GetList
    {
        public IEnumerable<Client> Types()
        {

            IEnumerable<Client> ty = null;

            using (AppDBContexts db = new AppDBContexts())
            {
                ty = (from a in db.Clients
                      select a).ToList();
            }

            return ty;

        }

        public IEnumerable<Package> Packageslist(string name)
        {

            IEnumerable<Package> PackList=null;

            using (AppDBContexts db = new AppDBContexts())
            {
                PackList = (from a in db.Packages
                            where a.Namepack.Contains(name)
                            select a).ToList();
            }

            return PackList;

        }

        public Package DetailsPackage(PackageRequest id)
        {

            using (AppDBContexts db = new AppDBContexts())
            {
                id.Product = (from a in db.Product
                            where a.IDPack.Equals(id.PackageID)
                            select a).ToList();
            }

            Package pack = new Package();
            pack.PackageID = id.PackageID;
            pack.Namepack = id.Namepack;
            pack.Product = id.Product;

            return pack;

        }

        public IEnumerable<Product> CommissionProductlist(IEnumerable<Package> packag)
        {

            IEnumerable<Product> List = null;

            using (AppDBContexts db = new AppDBContexts())
            {
                //db.Database.Log() = Console.Write;
                List = (from a in db.Product.ToList() 
                          join b in packag 
                          on a.IDPack equals b.PackageID 
                          select a).ToList();
                
            }

            return List;

        }
    }
}
