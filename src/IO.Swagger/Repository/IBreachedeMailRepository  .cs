using IO.Swagger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IO.Swagger.Repository
{
    public interface IBreachedeMailRepository
    {
        Breachedemail GetByEmail(string name);
        HashSet<string> GetAll();
        bool Add(Breachedemail breachedeMail);
        void Delete(string name);
    }
}
