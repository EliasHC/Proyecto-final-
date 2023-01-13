using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2
{
    public class Donacion : Usuario, IUsuario
    {
        public int dinero { set; get; }
        public Donacion(int id) : base(id)
        {
            this.dinero = 0;
        }
        public void donar()
        {
            ingresardatos();
            Console.WriteLine("Cuanto dinero usted desea donar?");
            dinero = int.Parse(Console.ReadLine());

            Console.WriteLine("Con que desea pagar?");
            Console.WriteLine("- paypal (1)");
            Console.WriteLine("- banco (2)");

            string pago = Console.ReadLine();
            Tipo tipo = new Tipo();
            tipo.tipo_de_pago(id, pago);
        }
        public void finalmessage()
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("                  GRACIAS POR DONARNOS");
            Console.WriteLine("");
            Console.WriteLine("    Nombre: "+nombre+ " Apellido: "+apellido);
            Console.WriteLine("    Cedula de Identidad: "+cedula);
            Console.WriteLine("    Domicilio: "+domicilio);
            Console.WriteLine("    Dinero donado: "+dinero+"$ :)");
            Console.WriteLine("");
            Console.WriteLine(" NO TE OLVIDES DE SEGUIRNOS EN NUESTRAS REDES SOCIALES, TE ESPERAMOS");
            Console.WriteLine(" QUE TENGAS UN EXCELENTE DIA :) ");
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------------------------");

        }

    }
}