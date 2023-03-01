using System;
using System.Collections.Generic;
using System.IO;

class Verificar
{
    public bool verificar_edad(Invitado invitado)
    {
        if (invitado.Edad >= 18)
        {
            return true;
        }
        else
        { 
            return false;
        }
    }
    public bool verificar_correo(string email)
    {
        string abecedario = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ1234567890";
        for (int i = 0; i < abecedario.Length; i++)
        {
            if (email.StartsWith(abecedario[i]))
            {
                return true;
            }
        }
        return false;
    }
    public bool verificar_conectores(Invitado invitado)
    {
        string email = invitado.Email;
        string[] info = email.Split("@"); //separar en dos partes antes y
        if (info.Length == 2)             //después del conector
        {
            string correo = info[0];
            email = info[1];
            if (verificar_correo(correo)) //si ya se verifico la primera parte del email (correo)
            {
                info = email.Split("."); //se parte la segunda parte a la mitad por el punto 
                string dominio = info[0]; // se guarda la primera parte en el arreglo y se le asigna como dominio


                if (dominio is "hotmail" || dominio is "gmail" || dominio is "live") //si cumple con los dominios devuelve TRUE
                {
                    if (info.Length == 2)                                       //Si el split por el punto devuelve dos partes
                    {
                        string terminacion = info[1];                           // se guarda la segunda en el arreglo como la terminación

                        if (terminacion is "com" || terminacion is "co" || terminacion is "org") //no incluye edu.co porque serían tres partes separadas por dos puntos
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else                           //edu.co
                    {
                        string terminacion_ = info[1];
                        string _terminacion = info[2];
                        if (terminacion_ is "edu" || _terminacion is "co")
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                else { return false; }
            }
            else { return false; }
        }
        else { return false; }
    }
}