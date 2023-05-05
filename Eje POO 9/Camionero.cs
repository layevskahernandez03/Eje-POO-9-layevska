using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eje_POO_9
{
    class Camionero
    {
        string nom;
        int telf;
        string direccion;
        double sal;
        int Cantpobla;
        float rfc;

        public Camionero(string nom, int telf, string direccion, double sal, int cantpobla, float rfc)
        {
            this.Nom = nom;
            this.Telf = telf;
            this.Direccion = direccion;
            this.Sal = sal;
            Cantpobla1 = cantpobla;
            this.Rfc = rfc;
        }

        public string Nom { get => nom; set => nom = value; }
        public int Telf { get => telf; set => telf = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public double Sal { get => sal; set => sal = value; }
        public int Cantpobla1 { get => Cantpobla; set => Cantpobla = value; }
        public float Rfc { get => rfc; set => rfc = value; }
    }
}
