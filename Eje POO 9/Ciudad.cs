using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eje_POO_9
{
    class Ciudad
    {
        int codigo;
        string nom;

        public Ciudad(int codigo, string nom)
        {
            this.Codigo = codigo;
            this.Nom = nom;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nom { get => nom; set => nom = value; }
    }
}
