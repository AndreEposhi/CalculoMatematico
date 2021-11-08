using System.Collections.Generic;

namespace CalculoMatematico.Web.Models
{
    public class DivisoresNumeroViewModel
    {
        public int Numero { get; set; }
        public IList<int> DivisoresNumeros { get; set; } = new List<int>();
        public IList<int> NumerosPrimos { get; set; } = new List<int>();
    }
}