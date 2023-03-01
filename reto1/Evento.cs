using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Evento
{
    public Reader lector_;                       //crear metodo de tipo clase Reader
    public Verificar verificar = new Verificar(); //llama a clase Verificar

    public string leer_archivo(string direccion)
    {
        if (direccion.Contains(".txt"))
        {
            lector_ = new ReaderTXT();
            return direccion;
        }
        else { return null; }
        
      
    }
    public Invitado buscar_invitado(int id)
    {
        foreach (Invitado invitado in lector_.list_invitados) //itera sobre los elementos de tipo Invitado de la lista invitados
        {
            if (invitado.Id == id)
                return invitado;
        }
        return null;
    }
   public void correr(string direccion)  
    {
        lector_.lector(direccion);
    }
 
    public void validar_invitado(int id)  //usa los metodos de la clase Verificar y lanza excepciones creadas
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
                        int Id_ = main.ingresar_id();
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
    public void print_lista(Invitado invitado)
    {


    }

}

