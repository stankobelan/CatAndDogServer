using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatAndDogServer.Models.interfacies
{
    public interface IPet
    {
        public string Name { get; set; }
        public int PocetKrmeni { get; set; }
        public DateTime DatumNarodenia { get; set; }    
    }
}
