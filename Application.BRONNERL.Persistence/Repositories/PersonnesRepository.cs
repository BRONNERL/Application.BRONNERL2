using Application.BRONNERL.Domain.Entities;
using Application.BRONNERL.Domain.Interfaces.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Application.BRONNERL.Persistence.Repositories
{
    public class PersonnesRepository : IPersonnesRepository
    {
        private readonly ApplicationContext Context;
        
        public PersonnesRepository(ApplicationContext dbContext) {
            Context = dbContext;
        }

        public async Task Add(Personne personne)
        {
            await Context.Personnes.AddAsync(personne);
            await Context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Personne>> GetAll()
        {
            return await Context.Personnes.ToListAsync();
        }
    }
}
