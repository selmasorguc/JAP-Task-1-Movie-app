namespace API.Entity
{
    public class Rating
    {
        public int Id { get; set; }
        public float Value { get; set; }
        public int MovieId { get; set; }
    }
}