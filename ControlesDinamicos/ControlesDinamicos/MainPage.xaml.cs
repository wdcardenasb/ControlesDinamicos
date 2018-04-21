using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ControlesDinamicos
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BotonUno.Clicked += BotonUno_Clicked;
        }

        private void BotonUno_Clicked(object sender, EventArgs e)
        {
            Panel.Children.Add(new Button()
            {
                Text=$"Boton {Panel.Children.Count+1}"
            });
        }
    }
}
