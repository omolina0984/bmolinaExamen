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
    public partial class Registro : ContentPage
    {
        public Registro(string user)
        {
            InitializeComponent();
            lblUsuario.Text = "Usuario:"+user;
        }

        private void btnGuardar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Informacion", "Elemento guardado con Exito", "ok");

            Navigation.PushAsync(new Resumen(lblUsuario.Text,txtNombre.Text,txtMontoInicial.Text, txtPagoMensual.Text));
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            double costo = 4000;
            var interes = 4000 * 0.05;
            var montoInicial = Convert.ToDouble(txtMontoInicial.Text);
            if (montoInicial < 4000)
            {
                txtPagoMensual.Text= (( (costo-montoInicial)/5)-interes).ToString();
                btnGuardar.IsEnabled = true;
            }
            else
            {
                DisplayAlert("El valor minimo ingresado excede lo permitido", "Vuelva a ingresar el valor correctamente", "Salir");
                txtMontoInicial.Text = string.Empty;
            }
          

        }
    }
}