using System.Drawing;

namespace PrivateBudget.Client.Models
{
    public class UserData
    {
        public Plan Plan { get; set; } = new Plan();

        public bool CurrentMonth { get; set; } = true;

        public bool VirtualBookign { get; set; } = false;

        public bool IgnoreDay { get; set; } = false;
    }
}
