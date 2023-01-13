using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto2
{
    public class CuentaBancaria : Cuenta
    {

        public CuentaBancaria(int id) : base(id)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Codigo de ID:" + id);
            Console.WriteLine("");
            Console.WriteLine("Puedes hacernos una donación aqui con este numero");
            Console.WriteLine("XXXXXXXX123 y luego revisar su correo porque le será enviado");
            Console.WriteLine("el comprobante de su donación. Gracias por Alegrar corazones");
            Console.WriteLine("");
            Console.WriteLine("---------------------------------");
        }
    }
}