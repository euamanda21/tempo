using TempoApp;

namespace Tempo;

public partial class MainPage : ContentPage	
{
    
	Resposta resposta;

	const string Url="https://api.hgbrasil.com/weather?woieid=455927&key=618e34cf";

	
	public MainPage()
{

		
		InitializeComponent();
		preencherTela();	
		
	}


	void preencherTela()
	{
        LabelTemperatura.Text= resposta.results.Temp.ToString();
        LabelTempo.Text= resposta.results.Description;
        LabelData.Text= resposta.results.date;
		LabelHora.Text= resposta.results.time;
		LabelCidade.Text= resposta.results.City;
		LabelHumidade.Text= resposta.results.Humidity.ToString();
        LabelVento.Text= resposta.results.Rain;
        LabelAmanhecer.Text= resposta.results.Sunrise;
        LabelAnoitecer.Text= resposta.results.Sunset;
        LabelVelocidade.Text= resposta.results. Wind_Speedy.ToString();
		LabelDireção.Text= resposta.results.Wind_Direction.ToString();
		LabelLua.Text= resposta.results.moon_phase;
    }

	

}