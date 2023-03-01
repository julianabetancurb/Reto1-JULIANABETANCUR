using System;

    class Invitado
    {
        string nombre;
        int id;
        string email;
        int edad;

        public Invitado(string Nombre_, int Edad_, string Email_, int Id_)
        {
            nombre = Nombre_;
            edad = Edad_;
            email = Email_;
            id = Id_;
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
      
    }

