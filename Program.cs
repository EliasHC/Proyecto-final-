using System;

namespace Proyecto2
{
    class Program
{

        public static void Main(String[] args)
        {
            int entrada = 0;
            Console.WriteLine("----BIENVENIDO A DAM----\n");
            Console.WriteLine("SI DESEA ENTRAR EN MODO ADMINISTRADOR SELECCIONE (1), SI DESEA INGRESAR EN MODO USUARIO SELECCIONE (2)");
            entrada = int.Parse(Console.ReadLine());
            //ENTRADA AL MODO ADMINISTRADIR MEDIANTE EL PROXY
            if (entrada == 1)
            {
                Console.WriteLine("Ingrese su contraseña de Administrador");
                //EJECUTAMOS NUESTRO PROXY PARA ENTRAR A LA BASE DE DATOS PRIVADA DE DEASCM
                Proxy.Privado privado = new Proxy.ProxySeguro();
                privado.Peticion(1);
            }
            //SI NO ENTRAMOS EN COMO ADMINISTRADOR, ENTRAREMOS EN MDODO USUARIO QUE NOS PERMITIRA DONAR 
            else if (entrada == 2)
            {
                Localidad localidad = new Localidad();
                localidad.identificador();
            }
            //SI NO SELECCIONAMOS NINGUNA DE LAS DOS OPCIONES ANTEIRORES NOS MOSTRARA UN MENSAJE DE QUE LA OPCION NO ESTA DISPONIBLE
            else
            {
                Console.WriteLine("Esta opcion no esta disponible");
            }
        }
    }
}