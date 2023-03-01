using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class program
{
    public static void Main(string[] args)
    { 
        Programa programa= new Programa();  

    }

        public static int ingresar_id()
        {
            Console.WriteLine("Ingrese el ID del invitado");
            try
            {
                int id = Convert.ToInt32(Console.ReadLine());
                return id;
            }
            catch
            {
                Console.WriteLine("Ingrese numeros sin letras");
                return ingresar_id();
            }
        
    }

}
