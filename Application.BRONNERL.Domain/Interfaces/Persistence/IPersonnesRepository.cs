using Application.BRONNERL.Domain.Entities;

namespace Application.BRONNERL.Domain.Interfaces.Persistence
{
    public interface IPersonnesRepository
    {
        Task<IEnumerable<Personne>> GetAll();
        Task Add(Personne personne);
    }
}
