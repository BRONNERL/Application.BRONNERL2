using Application.BRONNERL.Domain.Entities;

namespace Application.BRONNERL.Domain.Interfaces
{
    public interface IPersonnesService
    {
        Task<IEnumerable<Personne>> GetAll();
        Task Add(Personne personne);
    }
}
