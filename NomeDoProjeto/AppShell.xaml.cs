namespace NomeDoProjeto;

public partial class MainPage : ContentPage
{
	Results resultados;()
	int count=0;
	public MainPage()

	{
		InitializeComponent();
		TestaLayout();
		preencherTela();
	}

	void TestaLayout()
	{
      resultados=new Results();
	  resultados.Temp = 23;
	  resultados.Description = "tempo nublado";
	  resultados.date = "22/04/2024";
	  resultados.time = "08:55";
	  resultados.Currently ="dia";
	  resultados.City = "Apucarana,PR";
	  resultados.Humidity = "90";
	  resultados.Rain = "10";
	  resultados.Sunrise = "06:11 am";
	  resultados.Sunset = "06:39 pm";
	  resultados. Wind_Speedy = "4.99 km/h";
	  resultados.Wind_Direction = "40";
	  resultados.moon_phase = "cheia";
	
	  
	}

	void preencherTela()
	{
      
	}
}
