using Microsoft.VisualBasic;

namespace PrivateBudget.Client.Models
{
    public class Booking
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Value { get; set; }

        public Category? Category { get; set; }

        public DateOnly Date { get; set; }


        public Booking(Entry entry, int month, int year)
        {
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
