using System.Collections.Generic;

namespace CalculoMatematico.DivisoresNumero.Api.ViewModels
{
    public class DivisoresNumeroViewModel
    {
        public int Numero { get; set; }
        public IList<int> DivisoresNumeros { get; set; }
        public IList<int> NumerosPrimos { get; set; }
    }
}