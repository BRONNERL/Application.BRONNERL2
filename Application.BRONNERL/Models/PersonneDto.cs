using Application.BRONNERL.Domain.Interfaces.Entities;

namespace Application.BRONNERL.Models
{
    public class PersonneDto : IAgeable
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Age { get; set; }
        public DateTime DateDeNaissance { get; set; }
    }
}
