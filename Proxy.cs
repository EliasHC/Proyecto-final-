using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2
{
    internal class Proxy
    {
        public Proxy()
        {
        }
        //CREAMOS LA INTERFAZ PRIVADA PARA LA CREACIÓN DEL PROXY
        public interface Privado
        {
            void Peticion(int peti);
        }
        //ENCADENAMOS NUESTRAS CLASES
        public class ProxySeguro : Privado
        {
            private CPrivado nombre;
            public void Peticion(int peti)
            {
                string password;
                password = Console.ReadLine();
                //DECLARAMOS NUESTRA CONTRASEÑA DE USUARIO POR LA CUAL PODREMOS TENER ACCESO AL PROXY
                if (password == "admin123")
                {
                    if (nombre == null)
                    {
                        Console.WriteLine("----Ingresando en modo Administrador----");
                        nombre = new CPrivado();
                    }
                    if (peti == 1)
                        nombre.NombreSecreto();
                }
                else
                {
                    Console.WriteLine("Acceso Denegado");
                }
            }
        }
        //NUESTRA CLASE PRIVADA QUE SOLO SERÁ ACCESIBLE MEDIANTE EL PROXY
        private class CPrivado
        {
            public void NombreSecreto()
            {
                Console.WriteLine("Los usiarios que han donado son: ");
                Console.WriteLine("\n");
                Console.WriteLine("Luis Alfredo Mendoza");
                Console.WriteLine("Manuel Guillermo Cedeño");
                Console.WriteLine("Federico Fernando Cifuentes");
                // EN ESTA PARTE DE CPrivado ESTARA TODAS LAS PERSONAS QUE HAN DONADO
                // A ESTO SOLO TENDRAN ACCESO LOS ADMINISTRADORES Y LOS QUE CUENTEN CON LA CLAVE DE ACCESO 
            }
        }
    }
}
