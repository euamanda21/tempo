namespace NomeDoProjeto;

public partial class MainPage : ContentPage;

	
	public MainPage();
		InitializeComponent();

	
namespace tempo;

public partial class MainPage : ContentPage
{
	Results resultados;
	int count=0;
	public MainPage();
    

		InitializeComponent();
		TestaLayout();
		preencherTela();
	

	void TestaLayout()
	{
      resultados=new Results();
	  resultados.Temp = 23;
	  resultados.Description = "tempo nublado";
	  resultados.Date = "22042024";
	  resultados.Time = "0855";
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
      labelTemperature.Text = resultados.Temp;
	  labelDescription.Text = resultados.Description;
	  labelDate.Text = resultados.Date;
      labelTime.Text = resultados.Time;
	  labelCurrently.Text = resultados.Currently;
	  labelCity.Text = resultados.City;
	  labelHumidity.Text = resultados.Humidity;
	  labelRain.Text = resultados.Rain;
	  labelSunrise.Text = resultados.Sunrise;
	  labelSunset.Text = resultados.Sunset;
	  labelWind_Speedy.Text = resultados. Wind_Speedy;
	  labelWind_Direction.Text = resultados.Wind_Direction;
	  labelmoon_phase.Text = resultados.moon_phase;
    }
}

	


