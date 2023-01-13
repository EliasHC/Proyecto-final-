using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto2
{
    public class Cuenta:Usuario
    {
        public string email { set; get; }
        public string password { set; get; }
        public Cuenta(int id):base(id)
        {
            this.email = "donandocomida123@gmail.com";
            this.password = "Alegrandocorazones1234";
        }
        public void logeo(int id)
        {
            Console.WriteLine(id);
            Console.WriteLine("-------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Ingresa el correo de tu cuenta");
            email = Console.ReadLine();
            Console.WriteLine("Correo de paypal correcto.");
            Console.WriteLine("Ingresar tu contraseña de tu cuenta");
            password = Console.ReadLine();
            Console.WriteLine("contraseña de paypal correcto");
            Console.WriteLine("Has ingresado correctamente a paypal");
            Console.WriteLine("");
            Console.WriteLine("--------------------------------");
        }
    }
}