using Application.BRONNERL.Domain.Interfaces.Entities;

namespace Application.BRONNERL.Domain.Entities
{
    public class Personne : IAgeable
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateDeNaissance { get; set; }
    }
}