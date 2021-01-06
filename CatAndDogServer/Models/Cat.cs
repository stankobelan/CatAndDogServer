using CatAndDogServer.Models.interfacies;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatAndDogServer.Models
{
    public class Cat : IPet
    {
        [Key]
        public int Id { get; set; }
        public int PocetKrmeni { get; set; }
        public int PocetMaciatok { get; set; }
        public DateTime DatumNarodenia { get; set; }

        [ForeignKey("PetOwner")]
        public int PetOwnerId { get; set; }
        public PetOwner Owner { get; set; }
        public string Name { get ; set ; }
    }
}
