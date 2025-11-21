using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica
{
    internal class Biblioteca
    {
        string nome;
        string indirizzo;
        int orariApertura;
        int orariChiusura;

        public Biblioteca(string nome, string indirizzo,int orariApertura, int orariChiusura) 
        {
            nome = nome;
            indirizzo = indirizzo;
            orariApertura = orariApertura;
            orariChiusura = orariChiusura;
        }
    }
}
