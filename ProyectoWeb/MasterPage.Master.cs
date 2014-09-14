using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Biblioteca;
namespace ProyectoWeb
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        public  Persona persona
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


        private bool estado
        {

            get
            {
                if (Session["estado"]==null)
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

    

        protected void Page_Load(object sender, EventArgs e)
        {
            if (estado)
            {
                lnbtnLogin.Style.Clear();
                lnbtnLogin.Text = persona.User;
                lnbtnCrear.Font.Underline = false;
                lnbtnLogin.Enabled = false;

                lnbtnCrear.Text = "Perfil".ToString();

            }
            else
            {
                lnbtnLogin.Text = "Login";
                 lnbtnCrear.Font.Underline = true;
                 lnbtnLogin.Enabled = true;

                 lnbtnCrear.Text = "Crear";
               
            
            }

            
            

        }

        protected void lnbtnCrear_Click(object sender, EventArgs e)
        {
            if (lnbtnCrear.Text.Equals("Perfil"))
            {
                lnbtnCrear.PostBackUrl = "Perfil.aspx";

            }
            else
            {
                lnbtnCrear.PostBackUrl = "Registro.aspx";
            }

            Response.Redirect(lnbtnCrear.PostBackUrl);
        }

        protected void lnbtnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}