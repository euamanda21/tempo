using System.Net;
using TempoApp;

namespace Tempo;

public partial class MainPage : ContentPage	
{
    InitializeComponent();
	public MainPage();
	
	Resposta resposta;

	const string Url="https://api.hgbrasil.com/weather?woieid=455927&key=618e34cf";
    	preencherTela();
		AtualizaTempo();	
		
	}


	void preencherTela()
	{
        Label=Chuva.Text= resposta.results.Chuva.ToString();
		LabelHumidade.Text= resposta.results.Humidade.ToString();
        LabelAmanhecer.Text= resposta.results.Amanhecer;
        LabelAnoitecer.Text= resposta.results.Amanhecer;
		LabelSol.Text= resposta.results.Sol;
		LabelForça.Text= resposta.results.Força;
		LabelDireção.Text= resposta.results.Descrição;
        LabelVento.Text= resposta.results.Rain;
        LabelFase.Text= resposta.results.Sunrise;
        LabelAnoitecer.Text= resposta.results.Sunset;
        LabelVelocidade.Text= resposta.results. Wind_Speedy.ToString();
		LabelDireção.Text= resposta.results.Wind_Direction.ToString();
		LabelLua.Text= resposta.results.moon_phase;
    }
    async void AtualizaTempo();
	{
		try
		
			var httpCliente=new HttpClient();
			var response=await HttpClient.GetAsync(url);
			if (response.IsSucessStatusCode);
		
		
		
			string content=WebResponse.Content.ReadAsStringAsyng();
			Resposta = JsonSerialier.Deserialize<Resposta>(content);
		
	}
	
	

