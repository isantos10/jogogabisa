namespace Jogogabisa;

public partial class MainPage : ContentPage
{
	Aime aime;
	Theo theo;
    Liz  liz;
	Gatinhos atual;

	public MainPage()
	{
		InitializeComponent();
		aime = new Aime();
		theo = new Theo();
        liz  = new Liz();
		atual = aime;
		fotosdogato.Source= atual.GetNomeDaFoto();
	}

	void trocarclicado(object sender, EventArgs args)
	{
		if (atual == aime)
			atual = theo;
		else if (atual == theo)
			atual = liz;
		else if (atual == liz)
		     atual = aime;
		fotosdogato.Source = atual.GetNomeDaFoto();
	}
}

