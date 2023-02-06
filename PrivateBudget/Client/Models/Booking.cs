using Microsoft.VisualBasic;

namespace PrivateBudget.Client.Models
{
    public class Booking
    {
        public Entry Entry { get; }

        public string Name { get; }

        public string Description { get; }

        public decimal Value { get; }

        public Category? Category { get; }

        public DateOnly Date { get; }

        public Booking(Entry entry, int month, int year)
        {
            Entry = entry;
            Name = entry.Name;
            Description = entry.Description;
            Value = entry.Value;
            Category = entry.Category;

            int day = entry.StartDate.Day;
            int maxDays = DateTime.DaysInMonth(year, month);

            if (maxDays < day)
            {
                day = maxDays;
            }

            Date = new DateOnly(year, month, day);
        }
    }
}
