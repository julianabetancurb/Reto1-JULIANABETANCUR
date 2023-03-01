using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class main
{
    public static void Main(string[] args)
    {
        string direccion = "C:\\Users\\DIANA\\Downloads\\Taller_herencia.txt"; //se ingresa la ruta del archivo txt
        Evento programa= new Evento(); 

        programa.correr(direccion); 
        int id = ingresar_id(); 
        programa.validar_invitado(id);

    }

        public static int ingresar_id()
        {
            Console.WriteLine("Ingrese la identificación del invitado:");
            try
            {
                int id = Convert.ToInt32(Console.ReadLine());  //se pasa el id ingresado de string a int
                return id;
            }
            catch
            {
                Console.WriteLine("Ingrese numeros sin letras"); //el catch lanza la excepcion de que no se ingreso correctamente el ID
                return ingresar_id();
            }
        
    }

}
