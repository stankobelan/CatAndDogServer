using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatAndDogServer.Data
{
    public interface IDataContext
    {
        Task SaveChangesAsync();
    }
}
