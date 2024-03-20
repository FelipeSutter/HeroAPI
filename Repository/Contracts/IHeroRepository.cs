using Domain.Model.En;

namespace Repository.Contracts
{
    public interface IHeroRepository
    {
        Task<Hero> InsertHero(Hero hero);
    }
}
