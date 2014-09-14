using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Biblioteca;
namespace ProyectoWeb
{
    public partial class Registro : System.Web.UI.Page
    {
        public Persona persona
        {


            get
            {
                if (Session["Persona"] == null)
                {
                    Session["Persona"] = new Persona();
                }

                return (Persona)Session["Persona"];

            }

            set
            {
                Session["Persona"] = value;

            }
        }

        private List<Persona> lista_persona
        {
            get
            {
                if (Session["lista_persona"] == null)
                {
                    Session["lista_persona"] = new List<Persona>();
                }

                return (List<Persona>)Session["lista_persona"];
            }

            set
            {
                Session["lista_persona"] = value;

            }

        }


        private bool estado
        {

            get
            {
                if (Session["estado"] == null)
                {

                    Session["estado"] = false;
                }
                return (bool)Session["estado"];

            }
            set
            {
                Session["estado"] = value;

            }

        }

      


        private string devuelve_sexo()
        {
            if (M.Checked)
            {
                return M.ToString();
            }
            else
            {

                return F.ToString();
            }

        }
        private bool UsuarioExiste()
        {
            string nombre, pass, correo, sexo, user, pass2, rut;
            nombre = txtNombre.Text.Trim();
            pass = txtPass1.Text;
            pass2 = txtpass2.Text;
            correo = txtEmail.Text.Trim();
            user = txtUserRegistro.Text.Trim();
            sexo = devuelve_sexo();
            rut = TxtRut.Text;
            bool existe = false;
          

            foreach (Persona item in lista_persona)
            {
                if (item.User.ToUpper()==user.ToUpper())
                {
                    existe = true;
                    controlUser.Text = "Usuarios ya existe";
                    return existe;
                }
                else
                {
                    if (item.Correo.ToUpper()==correo.ToUpper())
                    {
                        existe = true;
                        ControlEmail.Text = "Usuarios ya existe";
                        return existe;
                    }
                   

                }


            }
            return existe;

        }
        private bool camposLLenados()
        {

            string nombre, pass1, correo, sexo, user, pass2, rut;
            nombre = txtNombre.Text.Trim();
            pass1 = txtPass1.Text;
            pass2 = txtpass2.Text;
            correo = txtEmail.Text.Trim();
            user = txtUserRegistro.Text.Trim();
            sexo = devuelve_sexo();
            rut = TxtRut.Text.Trim();
            bool llenado = true;


            if (nombre == "")
            {
                ControlNombre.Text = "Debe Completar el campos";
                llenado = false;
            }
            else
            {

                ControlNombre.Text = "";

            }
            if (pass1 == "")
            {
                ControlPass1.Text = "Debe Completar el  campos";
                llenado = false;
            }
            else
            {

                ControlPass1.Text = "";
            }
            if (rut == "")
            {
                ControlRut.Text = "Debe Completar el  campos";
                llenado = false;
            }
            else
            {

                ControlRut.Text = "";
            }
            if (pass2 == "")
            {
                ControlPass2.Text = "Debe Completar el  campos";
                llenado = false;
            }
            else
            {
                ControlPass2.Text = "";

            }
            if (correo == "")
            {
                ControlEmail2.Text = "Debe Completar el  campos";
                llenado = false;
            }
            else
            {
                ControlEmail2.Text = "";

            }
            if (user == "")
            {
                ControlUser2.Text = "Debe Completar el  campos";
                llenado = false;
            }
            else
            {

                ControlUser2.Text = "";

            }
            if (pass1!=pass2)
            {
                ControlPass3.Text = "las contraseñas no coinciden";
            llenado=false;
            }
            else
            {
                ControlPass3.Text="";
            }


            return llenado;






        }
        private bool UsuarioExitoso()
        {
            string nombre, pass, correo, sexo, user, pass2, rut;
            nombre = txtNombre.Text.Trim();
            pass = txtPass1.Text;
            pass2 = txtpass2.Text;
            correo = txtEmail.Text.Trim();
            user = txtUserRegistro.Text.Trim();
            sexo = devuelve_sexo();
            rut = TxtRut.Text;
            bool exitoso = false;


            if (camposLLenados())
            {
                if (!UsuarioExiste())
                {
                    
                    Persona p = new Persona(rut,sexo,correo,pass,user,nombre);
                    persona = p;
                    lista_persona.Add(p);
                    estado = true;
                    exitoso = true;
                }
                else
                {
                    estado = false;
                }
            }
            return exitoso;

        }
        protected void F_CheckedChanged(object sender, EventArgs e)
        {
            if (!F.Checked)
            {
                F.Checked = true;
                M.Checked = false;
            }
        }

        protected void M_CheckedChanged(object sender, EventArgs e)
        {

            if (!M.Checked)
            {
                M.Checked = true;
                F.Checked = false;
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (UsuarioExitoso())
            {
                Response.Redirect("Inicio.aspx");
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
    }
}