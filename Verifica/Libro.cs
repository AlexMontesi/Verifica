using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica
{
    internal class Libro
    {
        public string Titolo;
        public string Autore;
        public int Ore;
        public Libro(int NumeroPagine) 
        {
            if (NumeroPagine < 200)
            {
                throw new ArgumentException("L'anno di pubblicazione non può essere maggiore di 200.");
            }
            if (NumeroPagine < 100)
            {
                Ore = 1;
            }
            else 
            {
                Ore = 2;
            }
            
            
        }
    }
}
