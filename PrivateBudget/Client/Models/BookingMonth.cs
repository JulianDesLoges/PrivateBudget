namespace PrivateBudget.Client.Models
{
    public class BookingMonth
    {
        public DateOnly MonthStart { get; }


        public IReadOnlyList<Booking> Bookings => _bookings;
        private readonly List<Booking> _bookings;


        public decimal Net { get; private set; }


        public BookingMonth(DateOnly monthStart)
        {
            MonthStart = new DateOnly(monthStart.Year, monthStart.Month, 1);
            _bookings = new List<Booking>();

            Net = 0;
        }


        public void AddBooking(Booking booking)
        {
            _bookings.Add(booking);
            Net += booking.Value;
        }
    }
}
