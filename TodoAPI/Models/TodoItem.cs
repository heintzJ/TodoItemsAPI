namespace TodoAPI.Models
{
    public class TodoItem
    {
        // unique key for the database
        public long Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
        // secret field that others aren't supposed to see
        public string? Secret { get; set; }
    }
}
