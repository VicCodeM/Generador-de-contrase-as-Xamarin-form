using FrasesAzar;
using Plugin.Clipboard;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.TizenSpecific;

namespace GenerarPassword
{
    public partial class MainPage : ContentPage
    {
        int num = 8;
        //int bit = 0;    
        public MainPage()
        {
            InitializeComponent();
            string frasedia = "";
            Aleatorio jk = new Aleatorio();
            NumeroBits bit = new NumeroBits();
            int rn;
            rn= jk.Inicio(int.Parse(text2.Text));
            string pass = jk.Inn(rn);
            text2.Text = rn.ToString();
            labe6.Text= pass;
            labe3.Text = "Password con " + rn + " caracteres, seguridad media recomendada";
            if (checkbox2.IsChecked == false && checkbox2.IsChecked == false && checkbox3.IsChecked == false)
            {
                checkbox1.IsChecked = true;
                checkbox2.IsChecked = true;
                checkbox3.IsChecked = true;
                checkbox4.IsChecked = true;
            }
            labe6.Focus();
            labe8.Text = bit.CalcularBits(pass) + " Bits";

            FrasedelDia fg = new FrasedelDia();
            labe4.Text = fg.FrasedeHoy(frasedia);
             if ( rn>= 10 && rn < 16)
            {
                //label3.ForeColor = System.Drawing.Color.Tomato;
                Progreso.ProgressColor = Color.Yellow;
                labe6.TextColor = System.Drawing.Color.Yellow;
                Progreso.ProgressTo(0.35, 400, Easing.SpringIn);
                labe3.TextColor = System.Drawing.Color.Aqua;
                labe3.Text = "Password con " + rn + " caracteres, seguridad media recomendada";
            }

            else if (rn >= 16 && rn < 20)
            {
                // label3.ForeColor = System.Drawing.Color.Crimson;
                Progreso.ProgressColor = Color.GreenYellow;
                labe6.TextColor = System.Drawing.Color.GreenYellow;
                Progreso.ProgressTo(0.50, 400, Easing.SpringIn);
                labe3.TextColor = System.Drawing.Color.Aqua;
                labe3.Text = "Password con " + rn + " caracteres, seguridad alta recomendada";
            }

            else if (rn >= 20 && rn < 30)
            {
                Progreso.ProgressColor = Color.Green;
                labe6.TextColor = System.Drawing.Color.Green;
                Progreso.ProgressTo(0.99, 400, Easing.SpringIn);
                labe3.TextColor = System.Drawing.Color.Aqua;
                labe3.Text = "Password con " + rn + " caracteres, seguridad muy alta mejor recomendada";

            }
            
            labe7.Text = "Milisegundos: " + DateTime.Now.Millisecond;


        }

        private async void btnGenerar_Clicked(object sender, EventArgs e)
        {
            int longitud = Convert.ToInt32(text2.Text);
            Aleatorio gn = new Aleatorio();
            NumeroBits bit = new NumeroBits();
            if (checkbox1.IsChecked == true && checkbox2.IsChecked == false && checkbox3.IsChecked == false && checkbox4.IsChecked == false)
            { 
                string pass = gn.Abecedario(longitud);
                labe6.Text = pass;
                labe8.Text= bit.CalcularBits(pass)+" Bits";

            }
            else if (checkbox1.IsChecked == false && checkbox2.IsChecked == true && checkbox3.IsChecked == false && checkbox4.IsChecked == false)
            {
                
                string pass = gn.Numeros(longitud);
                labe6.Text = pass;
                labe8.Text = bit.CalcularBits(pass) + " Bits";
            }
            else if (checkbox1.IsChecked == false && checkbox2.IsChecked == false && checkbox3.IsChecked == true && checkbox4.IsChecked == false)
            {
                string pass = gn.Caracteres(longitud);
                labe6.Text = pass;
                labe8.Text = bit.CalcularBits(pass) + " Bits";
            }
            else if (checkbox1.IsChecked == false && checkbox2.IsChecked == false && checkbox3.IsChecked == false && checkbox4.IsChecked == true)
            {
                string pass = gn.Ascii(longitud);
                labe6.Text = pass;
                labe8.Text = bit.CalcularBits(pass) + " Bits";
            }
            else if (checkbox1.IsChecked == true && checkbox2.IsChecked == true && checkbox3.IsChecked == false && checkbox4.IsChecked == false)
            {
                string pass = gn.LetrasNumeros(longitud);
                labe6.Text = pass;
                labe8.Text = bit.CalcularBits(pass) + " Bits";
            }
            else if (checkbox1.IsChecked == true && checkbox2.IsChecked == false && checkbox3.IsChecked == true && checkbox4.IsChecked == false)
            {
                string pass = gn.LetrasCaracter(longitud);
                labe6.Text = pass;
                labe8.Text = bit.CalcularBits(pass) + " Bits";
            }
            else if (checkbox1.IsChecked == false && checkbox2.IsChecked == true && checkbox3.IsChecked == true && checkbox4.IsChecked == false)
            {
                string pass = gn.LetrasCaracter(longitud);
                labe6.Text = pass;
                labe8.Text = bit.CalcularBits(pass) + " Bits";
            }
            else if (checkbox1.IsChecked == true && checkbox2.IsChecked == false && checkbox3.IsChecked == false && checkbox4.IsChecked == true)
            {
                string pass = gn.LetrasAscii(longitud);
                labe6.Text = pass;
                labe8.Text = bit.CalcularBits(pass) + " Bits";
            }
           else if (checkbox1.IsChecked == false && checkbox2.IsChecked == true && checkbox3.IsChecked == false && checkbox4.IsChecked == true)
            {
                string pass = gn.NumerosAscii(longitud);
                labe6.Text = pass;
                labe8.Text = bit.CalcularBits(pass) + " Bits";
            }
            else if (checkbox1.IsChecked == false && checkbox2.IsChecked == false && checkbox3.IsChecked == true && checkbox4.IsChecked == true)
            {
                string pass = gn.CaracterAscii(longitud);
                labe6.Text = pass;
                labe8.Text = bit.CalcularBits(pass) + " Bits";
            }
            else if (checkbox2.IsChecked == true && checkbox2.IsChecked == true && checkbox3.IsChecked == true && checkbox4.IsChecked==true)
            {
                string pass = gn.Todos(longitud);
                labe6.Text = pass;
                labe8.Text = bit.CalcularBits(pass) + " Bits";
            }
            else if (checkbox2.IsChecked == true && checkbox2.IsChecked == true && checkbox3.IsChecked == true && checkbox4.IsChecked == false)
            {
                string pass = gn.LetNumCar(longitud);
                labe6.Text = pass;
                labe8.Text = bit.CalcularBits(pass) + " Bits";

            }
            else if (checkbox2.IsChecked == true && checkbox2.IsChecked == true && checkbox3.IsChecked == false && checkbox4.IsChecked == true)
            {
                string pass = gn.LetNumAss(longitud);
                labe6.Text = pass;
                labe8.Text = bit.CalcularBits(pass) + " Bits";

            }
            else if (checkbox2.IsChecked == false && checkbox2.IsChecked == false && checkbox3.IsChecked == false && checkbox4.IsChecked==true)
            {
                await DisplayAlert("Aviso selecciona una opción.", "Tienes que seleccionar una opción para poder generar una contraseña aleatoria.", "Aceptar");

            }
            if (longitud >= 1 && longitud < 5)
            {
                Progreso.ProgressColor = Color.Crimson;
                labe6.TextColor = System.Drawing.Color.Crimson;
                await Progreso.ProgressTo(0.15, 400, Easing.SpringIn);
                labe3.TextColor = System.Drawing.Color.Aqua;
                labe3.Text = "Password con " + longitud + " caracteres, no es admitida en varias páginas";
                await DisplayAlert("No recomendado", "la contraseña de " + longitud + " caracteres es demaciado corta, seguridad muy baja", "Aceptar");
                labe7.Text = "Milisegundos: " + DateTime.Now.Millisecond;  
            }
           

            else if (longitud >= 5 && longitud < 10)
            {
                //labe3.ForeColor = System.Drawing.Color.Salmon;
                Progreso.ProgressColor = Color.Crimson;
                labe6.TextColor = System.Drawing.Color.Crimson;
                await Progreso.ProgressTo(0.25, 400, Easing.SpringIn);
                labe3.TextColor = System.Drawing.Color.Aqua;
                labe3.Text = "Password con " + longitud + " caracteres, seguridad muy baja no recomendada";
                labe7.Text = "Milisegundos: " + DateTime.Now.Millisecond;
            }
          
            else if (longitud >= 10 && longitud < 16)
            {
                //label3.ForeColor = System.Drawing.Color.Tomato;
                Progreso.ProgressColor = Color.Yellow;
                labe6.TextColor = System.Drawing.Color.Yellow;
                await Progreso.ProgressTo(0.35, 400, Easing.SpringIn);
                labe3.TextColor = System.Drawing.Color.Aqua;
                labe3.Text = "Password con " + longitud + " caracteres, seguridad media recomendada";
                
                labe7.Text = "Milisegundos: " + DateTime.Now.Millisecond;
            }
          
            else if (longitud >= 16 && longitud < 20)
            {
                // label3.ForeColor = System.Drawing.Color.Crimson;
                Progreso.ProgressColor = Color.GreenYellow;
                labe6.TextColor = System.Drawing.Color.GreenYellow;
                await Progreso.ProgressTo(0.50, 400, Easing.SpringIn);
                labe3.TextColor = System.Drawing.Color.Aqua;
                labe3.Text = "Password con " + longitud + " caracteres, seguridad alta recomendada";
                labe7.Text = "Milisegundos: " + DateTime.Now.Millisecond;
            }
          
            else if (longitud >= 20 && longitud < 30)
            {
                Progreso.ProgressColor = Color.Green;
                labe6.TextColor = System.Drawing.Color.Green;
                await Progreso.ProgressTo(0.99, 400, Easing.SpringIn);
                labe3.TextColor = System.Drawing.Color.Aqua;
                labe3.Text = "Password con " + longitud + " caracteres, seguridad muy alta mejor recomendada";
                labe7.Text = "Milisegundos: " + DateTime.Now.Millisecond;

            }
           
            else if (longitud >= 30 && longitud < 399)
            {
                Progreso.ProgressColor = Color.Green;
                labe6.TextColor = System.Drawing.Color.Green;
                await Progreso.ProgressTo(0.99, 400, Easing.SpringIn);
                labe3.TextColor = System.Drawing.Color.Aqua;

                labe3.Text = "Password con " + longitud + " caracteres, no es admitida en varias páginas";
                labe7.Text = "Milisegundos: " + DateTime.Now.Millisecond;
            }
            else if (longitud >= 400 && longitud < 1000050)
            {
                Progreso.ProgressColor = Color.Green;
                await Progreso.ProgressTo(0.0, 400, Easing.SpringIn);
                labe6.TextColor = System.Drawing.Color.Red;
                //labe6.Text = "Demaciados caracteres para mostrar.";
                labe3.TextColor = System.Drawing.Color.Aqua;
                labe3.Text = "Password con " + longitud + " caracteres, no es admitida en varias páginas";
                await DisplayAlert("No recomendado", "la contraseña de " + longitud + " caracteres es muy larga, muchos sitios no admiten demciados caracteres", "Aceptar");
                labe7.Text = "Milisegundos: " + DateTime.Now.Millisecond;  
            }
        }

        private async void btnCopiar_Clicked(object sender, EventArgs e)
        {
            CrossClipboard.Current.SetText(labe6.Text);
            string clipboardText = await CrossClipboard.Current.GetTextAsync();
            labe5.Text ="Contraseña en portapapeles: \n" + clipboardText;
        }

    }
}
