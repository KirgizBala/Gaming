namespace Gaming.Entities
{
    public class Achievements
    {
        public int Id { get; set; }
        public Players Player { get; set; }
        public int PlayerId { get; set; }
        public string Desription { get; set; }
        public DateTime Date { get; set; }

    }
}
