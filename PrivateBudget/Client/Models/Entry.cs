using Microsoft.VisualBasic;

namespace PrivateBudget.Client.Models
{
    public class Entry
    {
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public decimal Value { get; set; } = 0.0m;

        public Category? Category { get; set; }

        public DateOnly StartDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);

        public DateOnly? EndDate { get; set; } = null;

        public DateInterval? Interval { get; set; } = null;
    }
}
