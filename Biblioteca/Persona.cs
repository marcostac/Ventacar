using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca
{
    public class Persona
    {

        private string rut;
        private string sexo;
        private string correo;
        private string pass;
        private string user;
        private string nombre;

        public string User
        {
            get { return user; }
            set { user = value; }
        }
        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }
        

     
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }


        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public string Rut
        {
            get { return rut; }
            set { rut = value; }
        }

        public Persona()
        {
        }

        public Persona(string rut,string sexo,string correo,string pass,string user,string nombre)
        {   this.rut=rut;
            this.sexo=sexo;
            this.correo=correo;
             this.pass = pass;
            this.user = user;
            this.nombre = nombre;
        }

        public Persona( string pass, string user, string nombre)
        {
            this.pass = pass;
            this.user = user;
            this.nombre = nombre;
        }

        public Persona(string pass, string user)
        {
            this.pass = pass;
            this.user = user;
            
        }
        public Persona(string pass, string user, string nombre,string correo)
        {
            this.pass = pass;
            this.user = user;
            this.nombre = nombre;
            this.correo = correo;
        }
    }
}
