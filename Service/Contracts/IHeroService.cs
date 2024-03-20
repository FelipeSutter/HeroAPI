using Domain.Model;

namespace Service.Contracts
{
    public interface IHeroService
    {
        Task<Hero> InsertHero(Hero hero);
    }
}
