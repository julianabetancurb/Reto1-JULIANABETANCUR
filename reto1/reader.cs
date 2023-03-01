using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;


        abstract class Reader //clase padre
        {
            //lista donde se almacenan los datos del TXT
            public List<Invitado> list_invitados = new List<Invitado>();
            
            public abstract void lector(string ruta); 

        }
        class ReaderTXT: Reader 
        {
        public override void lector(string ruta)
        {
            try
            {
            StreamReader sr = new StreamReader(ruta);
            sr.BaseStream.Seek(0, SeekOrigin.Begin); //ubica en una posición especifica a leer 
            string content = sr.ReadLine(); //se ignora la primera linea reasignandolo luego
            content = sr.ReadLine();
            while (content != null) //mientras el archivo no termine
            {
                string[] info = content.Split("    "); //separador por espacios 
                string nombre = info[0];
                int id = Convert.ToInt32(info[1]); //.ToInt32 para convertir de string a int
                string email = info[2];
                int edad = Convert.ToInt32(info[3]);
                Invitado invitado = new Invitado(nombre, id, email, edad); //crear invitado de tipo clase Invitado
                this.list_invitados.Add(invitado); //ingresar invitados a la lista
                content = sr.ReadLine();
            }
            sr.Close();

        }
            catch (FileNotFoundException)
            {
                Console.WriteLine("No se encuentra el archivo");

            }
            Console.ReadLine();
        }

   
    public void escritor (string ruta, string text)
    {
        string ruta = "C:\\Users\\DIANA\\Downloads\\Taller_herencia.txt";
        hackerman hackerman = new hackerman();
        string text = hackerman(hackerman);
        File.WriteAllText(ruta, text);
         





    }
    }

