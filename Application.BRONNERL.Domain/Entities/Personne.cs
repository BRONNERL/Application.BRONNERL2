using Application.BRONNERL.Domain.Interfaces.Entities;
using System.ComponentModel.DataAnnotations;

namespace Application.BRONNERL.Domain.Entities
{
    public class Personne : IAgeable
    {
        [Key]
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateDeNaissance { get; set; }
    }
}