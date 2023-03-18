namespace Gaming.Entities
{
    public class Results
    {
        public int Id { get; set; }
        public Players Player { get; set; }
        public int PlayerId { get; set; }
        public Games Game { get; set; }
        public int GameId { get; set; }
        public DateTime Date { get; set; }
        public string Result { get; set; }

    }
}
