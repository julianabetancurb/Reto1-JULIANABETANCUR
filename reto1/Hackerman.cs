using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class hackerman
{
    string newEmail;
    int newEdad; 


    public Hackerman(string newEmail, int newEdad)

    {
        Console.WriteLine("Ingrese el nuevo correo:");
        try
        {
            newEmail = Console.ReadLine();

        }
        catch (CorreoInvalidoException) { }

        Console.WriteLine("Ingrese la nueva edad:");
        newEdad = Convert.ToInt32(Console.ReadLine());

        if (newEdad >= 0 || newEdad <= 100)
        {
            newEdad = Convert.ToInt32(Console.ReadLine());
        }
        else { return "la edad no esta entre los rangos permitidos"; }



       
          
    }
}
