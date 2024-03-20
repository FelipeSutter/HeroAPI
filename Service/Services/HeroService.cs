using Domain.Model;
using Repository.Contracts;
using Service.Contracts;

namespace Service.Services
{
    public class HeroService : IHeroService
    {

        private readonly IHeroRepository _repository;

        public HeroService(IHeroRepository repository) => _repository = repository;

        public async Task<Hero> InsertHero(Hero hero)
        {
            if(hero.Name.Equals("Iron man"))
            {
                var friends = new List<string> { "", "" };

                foreach (var friend in friends)
                {
                    hero.AddHeroFriend(friend);
                }

            }
            return await _repository.InsertHero(hero);
        }
    }
}
