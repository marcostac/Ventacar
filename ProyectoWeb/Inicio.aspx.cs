using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Biblioteca;
using System.Collections;
namespace ProyectoWeb
{
    public partial class Inicio : System.Web.UI.Page
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

        private void CargarListaPersona()
        {

            lista_persona.Add(new Persona("123", "User123", "Mario","marioc@m.cl"));


        }
        protected void Page_Load(object sender, EventArgs e)
        {


            if (!IsPostBack)
            {

                CargarListaPersona();
            }
            

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx?PaginiaAnterior=Inicio.aspx");
        }
        

       


    }
}