using System.Drawing;

namespace PrivateBudget.Client.Utils
{
    public static class Extensions
    {
        public static string ToHex(this Color c) => $"#{c.R:X2}{c.G:X2}{c.B:X2}";
    }
}
