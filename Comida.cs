
namespace Proyecto2
{
    public class Comida : Usuario, IUsuario
    {
        public int comida { set; get; }
        public Comida(int id) : base(id)
        {
            this.comida = 0;
        }
        
        public void donar()
        {
            ingresardatos();
            Console.WriteLine("Cuanta comida usted desea donar?");
            comida = int.Parse(Console.ReadLine());
        }
        public void finalmessage()
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Nombre: "+ nombre+ " Apellido: "+ apellido+ "  cedula "+cedula);
            Console.WriteLine("");
            Console.WriteLine("Codigo de ID:" + id);
            Console.WriteLine("");
            Console.WriteLine("Contactanos para realizar tu donación de alimento");
            Console.WriteLine("");
            Console.WriteLine(" Telefono: +593-xxxxxxxxx");
            Console.WriteLine(" Correo electronico: donacion@gmail.com");
            Console.WriteLine(" Convencional: XXXXXXXX");
            Console.WriteLine("");
            Console.WriteLine(" Horarios de Atencion:");
            Console.WriteLine("  Lunes - Viernes de 8:00 am a 18:00 pm");
            Console.WriteLine("  Sabado 8:00 am a 14:00");
            Console.WriteLine("");
            Console.WriteLine("  Ayudanos a ayudarnos");
            Console.WriteLine(" Recuerda que con una pequeña donación puedes");
            Console.WriteLine(" Alegrar la vida de las personas que estan en las calles de Manta");
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------");




        }

    }
}