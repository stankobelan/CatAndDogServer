using System;
using System.ComponentModel.DataAnnotations;

namespace CatAndDogServer.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        public string Email { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        
        public bool Answered { get; set; }
        
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

    }
}
