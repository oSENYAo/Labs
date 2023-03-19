namespace Labs.SecondLab
{
    public class Knight
    {
        private string _name;
        private string _nickName;
        private int _age;
        private string _girlfriendName;

        public Knight(string name, string nickName, int age, Princess princess)
        {
            _name = name;
            _nickName = nickName;
            _age = age;

            if (princess?.HaveHusband == false)
                _girlfriendName = princess?.Name;
            Popularity = PopularityKnight.MaxPopularity;
            CalculatePopularity();
        }

        public int Popularity { get; private set; }
        public bool HaveGirlFriend => String.IsNullOrEmpty(_girlfriendName) == false;

        private void CalculatePopularity()
        {
            if (String.IsNullOrEmpty(_name) || String.IsNullOrEmpty(_nickName))
                Popularity = PopularityKnight.MaxPopularity - 15;
            
            if (_age > 60)
                Popularity = PopularityKnight.MaxPopularity - 20;

            if (Popularity < PopularityKnight.MinPopularity || Popularity < PopularityKnight.MaxPopularity)
                Console.WriteLine("Дисквалифицирован!");
        }
    }
}
