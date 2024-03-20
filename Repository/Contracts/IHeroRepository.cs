using Domain.Model;

namespace Repository.Contracts
{
    public interface IHeroRepository
    {
        Task<Hero> InsertHero(Hero hero);
    }
}
