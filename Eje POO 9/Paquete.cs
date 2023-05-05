using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eje_POO_9
{
    class Paquete
    {
        int codigo;
        string des;
        string destinatario;
        string direccion;

        public Paquete(int codigo, string des, string destinatario, string direccion)
        {
            this.Codigo = codigo;
            this.Des = des;
            this.Destinatario = destinatario;
            this.Direccion = direccion;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Des { get => des; set => des = value; }
        public string Destinatario { get => destinatario; set => destinatario = value; }
        public string Direccion { get => direccion; set => direccion = value; }
    }
}
