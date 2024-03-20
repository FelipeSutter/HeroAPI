namespace Domain.Model
{
    public class Hero
    {

        private readonly IList<string> _heroFriend;

        public Hero(string name, string power)
        {
            _heroFriend = new List<string>();
            HeroId = Guid.NewGuid();
            Name = name;
            Power = power;
        }

        public Guid HeroId { get; private set; }
        public string Name { get; private set; }
        public string Power { get; private set; }

        public void AddHeroFriend(string hero) => _heroFriend.Add(hero);

        private static Guid GetHeroGuid(Guid heroId)
        {
            Guid hero = heroId;

            if (hero == Guid.Empty)
            {
                hero = Guid.NewGuid();
            }

            return hero;
        }


    }

}
