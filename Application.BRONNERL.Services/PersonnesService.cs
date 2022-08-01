using Application.BRONNERL.Domain.Entities;
using Application.BRONNERL.Domain.Interfaces;
using Application.BRONNERL.Domain.Interfaces.Persistence;
using Application.BRONNERL.Helpers;

namespace Application.BRONNERL.Services
{
    public class PersonnesService : IPersonnesService
    {
        private readonly IPersonnesRepository _personnesRepository;

        public PersonnesService(IPersonnesRepository personnesRepository)
        {
            _personnesRepository = personnesRepository;
        }

        public async Task Add(Personne personne)
        {
            if (AgeHelper.GetAge(personne) > 150)
            {
                await _personnesRepository.Add(personne);
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public async Task<IEnumerable<Personne>> GetAll()
        {
            return (await _personnesRepository.GetAll())
                .OrderBy(p => p.Nom);
        }
    }
}