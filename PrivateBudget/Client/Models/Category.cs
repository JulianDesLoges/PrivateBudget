using System.Drawing;

namespace PrivateBudget.Client.Models
{
    public class Category
    {
        public string Name { get; set; } = string.Empty;

        public Color Color { get; set; } = Color.White;

        public decimal? MonthlyBudget { get; set; } = null;
    }
}
