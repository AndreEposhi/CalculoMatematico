using System.Collections.Generic;

namespace CalculoMatematico.Web.Models
{
    public class DivisorViewModel
    {
        public int Numero { get; set; }
        public IList<int> Divisores { get; set; } = new List<int>();
        public IList<int> NumerosPrimos { get; set; } = new List<int>();
    }
}