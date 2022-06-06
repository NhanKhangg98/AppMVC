using System;

namespace AppMVC.Net.Models
{
    public class PaggingModel
    {
        public int currentpage { get; set; }
        public int countpages { get; set; }

        public Func<int?, string> generateUrl { get; set; }
    }
}
