using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace bmolinaExamen.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {

            try
            {
                var usuario = txtUsuario.Text;
                var pass = txtPass.Text;

                if(usuario== "estudiante2023" && pass == "uisrael2023")
                {

                    DisplayAlert("Usuario", "Usuario Conectado", "OK");
                    Navigation.PushAsync(new Registro(usuario));


                }
                else 
                {
                    //mensaje de validacion de usuario
                     DisplayAlert("Usuario", "Usuario o contrasenia incorrectos", "Salir");

                  
                }



            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}