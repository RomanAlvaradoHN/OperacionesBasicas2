using OperacionesBasicas2.respuestas;

namespace OperacionesBasicas2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        //Accion boton sumar
        private void btnSumar_Clicked(object sender, EventArgs e)
        {
            //Verificar campos vacios
            if (string.IsNullOrWhiteSpace(input1.Text) || string.IsNullOrWhiteSpace(input2.Text))
            {
                DisplayAlert("Advertencia", "Por favor, ingrese ambos números.", "Aceptar");
                return;
            }

            double num1 = double.Parse(input1.Text);
            double num2 = double.Parse(input2.Text);
            double result = num1 + num2;
            Navigation.PushAsync(new PantallaRespuestas1(result));
        }





        //Accion boton restar
        private void btnRestar_Clicked(object sender, EventArgs e)
        {
            //Verificar campos vacios
            if (string.IsNullOrWhiteSpace(input1.Text) || string.IsNullOrWhiteSpace(input2.Text))
            {
                DisplayAlert("Advertencia", "Por favor, ingrese ambos números.", "Aceptar");
                return;
            }
            double num1 = double.Parse(input1.Text);
            double num2 = double.Parse(input2.Text);
            double result = num1 - num2;
            Navigation.PushAsync(new PantallaRespuestas1(result));
        }






        //Accion boton multiplicar
        private void btnMultiplicar_Clicked(object sender, EventArgs e)
        {
            //Verificar campos vacios
            if (string.IsNullOrWhiteSpace(input1.Text) || string.IsNullOrWhiteSpace(input2.Text))
            {
                DisplayAlert("Advertencia", "Por favor, ingrese ambos números.", "Aceptar");
                return;
            }
            double num1 = double.Parse(input1.Text);
            double num2 = double.Parse(input2.Text);
            double result = num1 * num2;
            Navigation.PushAsync(new PantallaRespuestas1(result));
        }








        //Accion boton dividir
        private void btnDividir_Clicked(object sender, EventArgs e)
        {
            //Verificar campos vacios
            if (string.IsNullOrWhiteSpace(input1.Text) || string.IsNullOrWhiteSpace(input2.Text))
            {
                DisplayAlert("Advertencia", "Por favor, ingrese ambos números.", "Aceptar");
                return;
            }
            double num1 = double.Parse(input1.Text);
            double num2 = double.Parse(input2.Text);

            if (num2 != 0)
            {
                double result = num1 / num2;
                Navigation.PushAsync(new PantallaRespuestas1(result));
            }
            else
            {
                DisplayAlert("Error", "No se puede dividir entre cero", "OK");
            }
        }









        //Accion boton limpiar
        private void btnLimpiar_Clicked(object sender, EventArgs e)
        {
            input1.Text = string.Empty;
            input2.Text = string.Empty;
        }










        //Accion boton salir
        private void btnSalir_Clicked(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }


    }
}