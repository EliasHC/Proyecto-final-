using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto2
{
    public class Usuario
    {
        public int id { set; get; }
        public string nombre { set; get; }
        public string apellido { set; get; }
        public string domicilio { set; get; }
        public int cedula { set; get; }
        public Usuario(int id)
        {
            this.id = id;
            this.nombre = "";
            this.apellido = "";
            this.domicilio = "";
            this.cedula = 0;
        }

        public void ingresardatos()
        {
            Console.WriteLine("Ingresar el nombre del donante:");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingresar el Apellido del donante:");
            apellido = Console.ReadLine();

            Console.WriteLine("Ingresar el numero de identidad del donante:");
            cedula = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar el domiclio del donante:");
            domicilio = Console.ReadLine();


        }

    }
}