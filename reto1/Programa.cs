using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Programa
{
    public Reader lector;
    public Verificar verificar = new Verificar();

    public void leer_archivo(string ruta)
    {
        lector = new ReaderTXT();
      
    }
    public Invitado buscar_invitado(int id)
    {
        foreach (Invitado invitado in lector.list_invitados)
        {
            if (invitado.Id == id)
                return invitado;
        }
        return null;
    }
 
    public void validar_invitado(int id)
    {
        Invitado invitado= buscar_invitado(id); 
        try
        {
            if (invitado != null)
            {
                if (verificar.verificar_edad(invitado))
                {
                    if (verificar.verificar_conectores(invitado))
                    {
                        Console.WriteLine("La persona se encuentra registrada y cumple con los requisitos");
                        int Id_ = program.ingresar_id();
                        validar_invitado(Id_);

                    }
                    else
                    { throw new CorreoInvalidoException();  }



                }
                else { throw new InvitadoMenorEdadException(); }
            }
            else {  throw new InvitadoNoRegistradoException(); }
        }
        catch (CorreoInvalidoException)
        {
            Console.WriteLine("El correo registrado es incorrecto");
        }
        catch (InvitadoMenorEdadException)
        {
            Console.WriteLine("El invitado es menor de edad");
        }
        catch (InvitadoNoRegistradoException)
        {
            Console.WriteLine("El invitado no está registrado");
        }
    } 

}

