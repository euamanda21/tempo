namespace Tempo;

public partial class MainPage : ContentPage;   	

{   Resposta resposta;

	const string Url="https://apihgbrasil.com/weather?woieid=455927&key=618e34cf";

	int count = 0;
	public MainPage()
{
		InitializeComponent();
		TestaLayout();
		preencherTela();
}

	void TestaLayout()
	{
      resultados=new Results();
	  resultados.Temp =23;
	  resultados.Description ="tempo nublado";
	  resultados.Date =22042024;
	  resultados.Time =0855;
	  resultados.Currently ="dia";
	  resultados.City = "Apucarana,PR";
	  resultados.Humidity = "90";
	  resultados.Rain ="10";
	  resultados.Sunrise = "06:11 am";
	  resultados.Sunset = "06:39 pm";
	  resultados. Wind_Speedy = "4.99 km/h";
	  resultados.Wind_Direction = 40;
	  resultados.moon_phase = "cheia";
	
	  
	}

	void preencherTela()
	{
      if (resultado.currently.rain>=10)
	    imgBackground.Source = "diachuvoso.jpg";
    }
}

	


