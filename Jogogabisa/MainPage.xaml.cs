namespace Jogogabisa;

public partial class MainPage : ContentPage
{


	public MainPage()
	{
		InitializeComponent();
		var aime= new Aime();
		
		fotosdogato.Source= aime.GetNomeDaFoto();
	}

	
}

