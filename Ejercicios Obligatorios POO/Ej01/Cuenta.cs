using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej01
{
    public class Cuenta
    {
        private string titular;
        private double saldo;

        public string Titular
        {
            get { return titular; }
            set { titular = value; }
        }

        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public Cuenta(string titular, double cantidad)
        {
            this.Titular = titular;
            this.Saldo = cantidad;
        }

        public Cuenta(string titular)
        {
            this.Titular = titular;
        }

        public void Ingresar(double cant)
        {
            if(cant > 0)
            {
                Saldo += cant;
            }
        }

        public void Retirar(double cant)
        {
            Saldo -= cant;
            if (Saldo < 0)
            {
                Saldo = 0;
            }
        }

        public void MostrarSaldo()
        {
            Console.WriteLine($"Su saldo es: {Saldo}");
        }

    }
}
