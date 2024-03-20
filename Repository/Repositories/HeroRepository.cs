using Domain.Model;
using Repository.Contracts;

namespace Repository.Repositories
{
    public class HeroRepository : IHeroRepository
    {
        public async Task<Hero> InsertHero(Hero hero)
        {
            return hero;
        }
    }
}
