using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio_Button
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Al preciomar el boton va a insertar el texto 
        private void Button_Clicked(object sender, EventArgs e)
        {
            (sender as Button).Text = "Felicidades";
        }
    }
}
