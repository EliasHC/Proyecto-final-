using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto2
{
    public class Localidad
    {
        public Localidad(){ }

        public void identificador()
        {
            Console.WriteLine("");
            Console.WriteLine("- Ingrese el número del país en el que reside actualmente");
            Console.WriteLine("");
            Console.WriteLine(" Ecuador (1)");
            Console.WriteLine(" Canada (2)");
            Console.WriteLine(" España (3)");
            Console.WriteLine(" EEUU (4)");
            Console.WriteLine(" Argentina (5)");
            Console.WriteLine(" Bolivia (6)");
            Console.WriteLine(" Chile (7)");
            Console.WriteLine(" Cuba (8)");
            Console.WriteLine(" Colombia (9)");
            Console.WriteLine(" Peru (10)");
            Console.WriteLine(" Guatemala (11)");
            Console.WriteLine(" Brasil (12)");
            Console.WriteLine(" Francia (13)");
            Console.WriteLine("");
            Console.WriteLine("");

            int escojer = int.Parse(Console.ReadLine());
            if (escojer == 1)
            {
                Console.WriteLine("Pais Vigente para las donaciones");
                Console.WriteLine("Ahora ingrese el número del canton que reside actualmente:");
                Console.WriteLine("");
                Console.WriteLine(" Tosagua (1)");
                Console.WriteLine(" Bolívar (2)");
                Console.WriteLine(" Olmedo (3)");
                Console.WriteLine(" Pichinca (4)");
                Console.WriteLine(" Jaramijó (5)");
                Console.WriteLine(" Jipijapa (6)");
                Console.WriteLine(" Junín (7)");
                Console.WriteLine(" Manta (8)");
                Console.WriteLine(" Montecristi (9)");
                Console.WriteLine(" Chone (10)");
                Console.WriteLine(" Paján (11)");
                Console.WriteLine(" Pedernales (12)");
                Console.WriteLine(" Jama (13)");
                Console.WriteLine(" Rocafuerte (14)");
                Console.WriteLine(" Sucre (15)");
                Console.WriteLine(" Portoviejo (16)");
                Console.WriteLine("");
                int canton = int.Parse(Console.ReadLine());

                if (canton == 8)
                {
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine("      SI ESTA DISPONIBLE LAS DONACIONES Y LOS ALIMENTOS");
                    Console.WriteLine("");
                    Console.WriteLine("------------------------------------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Tipo tipo = new Tipo();
                    tipo.tipo_de_donar(1,"all");
                }
                else
                {
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine("      SI ESTA DISPONIBLE LAS DONACIONES");
                    Console.WriteLine("");
                    Console.WriteLine("------------------------------------------------------------");
                    Console.WriteLine("");
                    Tipo tipo = new Tipo();
                    tipo.tipo_de_donar(1, "dinero");

                }

            }
            else if (escojer >= 2)
            {
                Console.WriteLine("El pais que acabas de ingresar no esta disponible");
                Console.WriteLine("para las donaciones, muchas gracias...");

            }

        }
   
}
}