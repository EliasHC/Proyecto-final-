using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto2
{
    public class Tipo
    {
        public Tipo(){}


   
        public void tipo_de_donar(int id,string selec)
        {
            Console.WriteLine("");
            Console.WriteLine("       Bienvenido a DAM   ");
            Console.WriteLine(" - Donacion para las personas que esten");
            Console.WriteLine("   en situación vulnerable en las calles de Manta");
            Console.WriteLine("");
            Console.WriteLine("       ¿Que es DAM?");
            Console.WriteLine(" DAM es una fundacion sin fin de lucro ");
            Console.WriteLine(" nuestro objetivo de brindarle una mejor");
            Console.WriteLine(" oportunidad a todos las personas");
            Console.WriteLine(" que esten en situacion vulnerable en las calles de la ciudad de Manta");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("        ¿Como Puedes ayudarnos?");
            Console.WriteLine(" Puedes brindarnos tu ayuda ya sea donando");
            Console.WriteLine(" dinero por medio de transacciones o depositos en ");
            Console.WriteLine(" Ecuador, tambien con alimentos de preferencia los mas usados frecuentemente");
            Console.WriteLine(" (esta disponible para las personas que viven en Manta).");
            Console.WriteLine("");
            Console.WriteLine("Elija su forma de donación");
            Console.WriteLine("");
            seleccionar(selec);
            Console.WriteLine("");
            string escojer = "";
            escojer = Console.ReadLine();
            if (escojer.Equals("dinero") || escojer.Equals("1"))
            {
                Donacion donacion = new Donacion(id);
                donacion.donar();
                donacion.finalmessage();

            }
            else if (escojer.Equals("comida") || escojer.Equals("2"))
            {
                Comida comida = new Comida(id);
                comida.donar();
                comida.finalmessage();

            }
            else
            {
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("NO SE ENCONTRO EL TIPO DE DONACION QUE DESEA");
                Console.WriteLine("");
                Console.WriteLine("-----------------------------------------------");

            }
        }

        public void seleccionar(string selec)
        {
            if (selec == "dinero")
            {
                Console.WriteLine("- dinero (1)");
            }
            else if (selec == "comida")
            {
                Console.WriteLine("- comida (2)");
            }else if(selec == "all")
            {
                Console.WriteLine("- dinero (1)");
                Console.WriteLine("- comida (2)");
            }
        }
        public void tipo_de_pago(int id, string pago)
        {
            if (pago.Equals("paypal") || pago.Equals("1"))
            {
                Paypal paypal = new Paypal(id);
            }
            else if (pago.Equals("banco") || pago.Equals("2"))
            {
                CuentaBancaria cuenta = new CuentaBancaria(id);
            }
        }
    }
}