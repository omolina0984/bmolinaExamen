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
    public partial class Resumen : ContentPage
    {
        public Resumen(string login, string nombre, string Inicial, string Pmensual)
        {
            InitializeComponent();
            lblUsuario.Text =  login;
            txtNombre.Text = nombre;
            txtTotal.Text = ((Convert.ToDouble(Pmensual)*5)+Convert.ToDouble(Inicial)).ToString();
        }

        private void btnAcercaDe_Clicked(object sender, EventArgs e)
        {

            DisplayAlert("Este proyecto fue realizado por:", "Brayan Molina 2023", "Salir");

        }
    }
}