using AttributesApp.Attributes;

namespace AttributesApp.Models
{
    //[Skill(nameof(Player),1,100)]
    internal class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Skill(nameof(BallControll), 1, 30)]
        public int BallControll { get; set; }
        [Skill(nameof(Dribbling), -30, 50)]
        public int Dribbling { get; set; }
        [Skill(nameof(Power), 0, 100)]
        public int Power { get; set; }
        [Skill(nameof(Speed), 150, 300)]
        public int Speed { get; set; }
        [Skill(nameof(Passing), 10, 1000)]
        public int Passing { get; set; }
    }
}
