namespace StarWarsInfo.Models
{
    public class PeopleModel
    {
        public int Count { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }
        public CharacterModel[] Results { get; set; }
    }
}
