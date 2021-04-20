using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IDBRepository
    {
        public Task<IEnumerable<ClientType>> GetClientTypes();


        public Task<IEnumerable<Package>> GetPackageslist(string name);


        public Task<Package> GetDetailsPackage(Package pack);


        public Task<IEnumerable<Product>> GetProductlist(int[] packag);
        
    }
}
