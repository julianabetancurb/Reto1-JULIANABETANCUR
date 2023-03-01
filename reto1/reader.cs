using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;


        abstract class Reader //clase padre
        {   
            public List<Invitado> list_invitados = new List<Invitado>();
            public abstract void lector(string ruta); 
        }
        class ReaderTXT: Reader 
        {
        public override void lector(string ruta)
        {
            try
            {
            StreamReader sr = new StreamReader("C:\\Users\\DIANA\\Downloads\\Taller_herencia.txt");
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string content = sr.ReadLine(); //se ignora la primera linea reasignandolo luego
            content = sr.ReadLine();
            while (content != null)
            {
                string[] info = content.Split("    "); //separador por espacios 
                string nombre = info[0];
                int id = Convert.ToInt32(info[1]); //.ToInt32 para convertir de string a int
                string email = info[2];
                int edad = Convert.ToInt32(info[3]);
                Invitado invitado = new Invitado(nombre, id, email, edad);
                this.list_invitados.Add(invitado);
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
    }

