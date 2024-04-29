using System.Net;
using TempoApp;

namespace Tempo;

public partial class MainPage : ContentPage	
{
    InitializeComponent();
	Public MainPage()
	
	Resposta resposta;

	const string Url="https://api.hgbrasil.com/weather?woieid=455927&key=618e34cf";
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
    async void AtualizTempo()
	{ 
		try
		{
			var httpCliente=new HttpClient();
			var response=await HttpClient.GetAsync(url);
			if (response.IsSucessStatusCode)
		}
		{
			string content=WebResponse.Content.ReadAsStringAsyng();
			Resposta = JsonSerialier.Deseialize<Resposta>(content);
		}
	}
	

