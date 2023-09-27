namespace OperacionesBasicas2.respuestas;

public partial class PantallaRespuestas1 : ContentPage
{
	public PantallaRespuestas1(double result)
	{
		InitializeComponent();
        resultLabel.Text = $"El resultado es: {result}";
    }
}