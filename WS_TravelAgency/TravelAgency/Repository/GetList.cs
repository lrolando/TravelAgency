using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelAgency.Models;

namespace TravelAgency.Repository
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

        public Package DetailsPackage(Package id)
        {

            using (AppDBContexts db = new AppDBContexts())
            {
                id.Product = (from a in db.Product
                            where a.IDPack.Equals(id.PackageID)
                            select a).ToList();
            }

            return id;

        }

    }
}
