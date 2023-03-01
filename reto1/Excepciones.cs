using System;

public class CorreoInvalidoException : Exception
{
    public CorreoInvalidoException() : base() { } // Primer constructor y se hereda
    public CorreoInvalidoException(string message) : base(message) //Segundo constructor que define mensaje personalizado
    {
        Console.WriteLine(message);
    }
}
public class InvitadoMenorEdadException : Exception
{
    public InvitadoMenorEdadException() : base() { }
    public InvitadoMenorEdadException(string message) : base(message) 
    { 
        Console.WriteLine(message);
    }
}

public class InvitadoNoRegistradoException : Exception
{
    public InvitadoNoRegistradoException() : base() { }
    public InvitadoNoRegistradoException(string message) : base(message)
    {
        Console.WriteLine(message); 
    }
}
public class EdadInvalidaException : Exception
{
    public EdadInvalidaException() : base() { }
    public EdadInvalidaException(string message) : base(message)
    {
        Console.WriteLine(message);
    }
}