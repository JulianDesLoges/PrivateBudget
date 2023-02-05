namespace PrivateBudget.Client.Models
{
    public class Plan
    {
        public string Name { get; set; } = "New Plan";

        public List<Entry> Entries { get; set; } = new List<Entry>();

        public List<Category?> Categories { get; set; } = new List<Category?>() { null };

        public Category? IncomeCategory { get; set; }
    }
}
