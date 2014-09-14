using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Biblioteca;
namespace ProyectoWeb
{
    public partial class Login : System.Web.UI.Page
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
                 if (Session["lista_persona"]==null)
	            {
		            Session["lista_persona"]=new List<Persona>();
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

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
               

            }


          


            
        }
     
        private Persona UsuarioExisteLogin()
        {
            string  pass ,user;
         
            pass=txtPassLogin.Text;
            
            
            user=txtUserLogin.Text.Trim();

            Persona objPersona=null;


            foreach (Persona item in lista_persona)
            {
                if (item.Pass.Equals(pass))
                {


                    objPersona = item;
                    
                    
                }
               
                

            }
            return objPersona;

            }
        private bool camposLLenados()
        {

              string user, passLogin;
              user = txtUserLogin.Text;
            passLogin=txtPassLogin.Text;
         
            bool llenado = true;
        

                if (passLogin == null)
                {
                   ControlPassLogin.Text="Debe Completar el  campos";
                   llenado = false;
                }
                else
                {
                
                ControlPassLogin.Text="";
                }
               
               
           
                 if (user==null)
	                {
		              ControlUserLogin.Text="Debe Completar el  campos";
                      llenado = false;
	                }
                 else{
                 
                  ControlUserLogin.Text="";
                 
                 }



                 return llenado;



       

           
        }
        private bool UsuarioExitosoLogin(){
         string  pass, user;
    
            pass=txtPassLogin.Text;
           
       
            user=txtUserLogin.Text.Trim();
            
          
            bool exitoso = false;


            if (UsuarioExisteLogin()!=null)
            {
                if (camposLLenados())
                {

                    persona = UsuarioExisteLogin();
                    estado = true;
                    exitoso = true;
                }
            }
            
            return exitoso;
        
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (UsuarioExitosoLogin())
            {
                Response.Redirect("Inicio.aspx");
            }
        }
        
        

      


       

        
    }
}