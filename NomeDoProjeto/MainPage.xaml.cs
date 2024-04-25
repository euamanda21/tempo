using TempoApp;

namespace Tempo;

public partial class MainPage : ContentPage	
{
 
	Resposta resposta;

	const string Url="https://apihgbrasil.com/weather?woieid=455927&key=618e34cf";

	
	public MainPage()
{

		
		InitializeComponent();
		preencherTela();	
		
	}


	void preencherTela()
	{
        Labelchuva.Text= resposta.results.Temp.ToString();
	    ImgBackground.Source = "diachuvoso.jpg";
        LabelSol.Text= resposta.results.Temp.ToString();
	    ImgBackground.Source = "diasol.jpg";
        LabelNublado.Text= resposta.results.Temp.ToString();
	    Imgbackground.Source = "dianublado.jpg";
        Labelnoitechuva.Text= resposta.results.Temp.ToString();
	    ImgBackground.Source = "noitechuvosa.jpg";
        Labelnoiteestrelada.Text= resposta.results.Temp.ToString();
	    ImgBackground.Source = "noiteestrelada.jpg";
        Labelnoitenublada.Text= resposta.results.Temp.ToString();
	    ImgBackground.Source = "noitenublada.jpg";
    }

	


}