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

        public BookingInterval Interval { get; set; } = BookingInterval.SingleTime;



        public bool HappensThisMonth(DateOnly monthStart)
        {
            DateOnly monthEnd = monthStart.AddMonths(1);

            return Interval switch
            {
                BookingInterval.SingleTime => StartDate >= monthStart && StartDate <= monthEnd,
                BookingInterval.Monthly => StartDate.Month <= monthStart.Month
                                        && StartDate.Year <= monthStart.Year
                                        && (EndDate?.Month ?? monthEnd.Month) >= monthEnd.Month
                                        && (EndDate?.Year ?? monthEnd.Year) >= monthEnd.Year,
                BookingInterval.Yearly => StartDate.Month == monthStart.Month
                                        && StartDate.Year <= monthStart.Year
                                        && (EndDate?.Year ?? monthEnd.Year) >= monthEnd.Year,
                _ => false,
            };
        }
    }
}
