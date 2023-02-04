using System.Diagnostics.CodeAnalysis;
using System.Drawing;

namespace PrivateBudget.Client.Models
{
    public class Category
    {
        public string Name { get; set; } = string.Empty;

        public string Color { get; set; } = "#FFF";

        public decimal? MonthlyBudget { get; set; } = null;

        public override bool Equals(object? obj)
        {
            return obj is Category category &&
                   Name == category.Name &&
                   Color == category.Color &&
                   MonthlyBudget == category.MonthlyBudget;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Color, MonthlyBudget);
        }
    }
}
