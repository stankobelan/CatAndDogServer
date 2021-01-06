using CatAndDogServer.Models.interfacies;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CatAndDogServer.Models
{
    public class Dog : IPet
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("PetOwner")]
        public int PetOwnerId { get; set; }

        public PetOwner Owner { get; set; }

        public int PocetKrmeni { get; set; }

        [Required]
        public DateTime DatumNarodenia { get; set; }
        public int PocetUhriznuti { get; set; }
        public string Name { get; set; }
    }
}
