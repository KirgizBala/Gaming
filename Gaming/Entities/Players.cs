namespace Gaming.Entities
{
    public class Players
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string level { get; set; }
        public List<Results> Results { get; set; }
    }
}
